/*
 * 使用广度优先搜索探索迷宫
 * 
 */

using System;
using System.Collections.Generic;

namespace Algorithms.BreadthFilstSearch
{
    /// <summary>
    /// 走迷宫
    /// </summary>
    public class Labyrinth
    {
        /// <summary>
        /// 坐标
        /// </summary>
        public struct Coordinate
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Coordinate(int x, int y)
            {
                X = x;
                Y = y;
                Path = new List<Coordinate>(0);
                Step = 0;
            }
            public Coordinate(int x, int y, Coordinate[] path)
            {
                X = x;
                Y = y;
                Path = new List<Coordinate>(path.Length);
                Path.AddRange(path);
                Step = path.Length;
            }

            /// <summary>
            /// 经过的路径，不包括自己
            /// </summary>
            public List<Coordinate> Path { get; set; }
            public int Step { get; internal set; }
            public override string ToString()
            {
                return $"{{{X},{Y}}}";
            }

            public override int GetHashCode()
            {
                string value = $"{X}0{Y}";
                int code = int.Parse(value);
                return code;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Coordinate))
                    return false;
                Coordinate compareValue = (Coordinate)obj;
                return GetHashCode() == compareValue.GetHashCode();
            }

            /// <summary>
            /// 往左走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveLeft()
            {
                Coordinate[] parents = new Coordinate[Path.Count + 1];
                Path.CopyTo(parents);
                parents[^1] = new Coordinate(X, Y);
                return new Coordinate(X - 1, Y, parents);
            }

            /// <summary>
            /// 往右走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveRight()
            {
                Coordinate[] parents = new Coordinate[Path.Count + 1];
                Path.CopyTo(parents);
                parents[^1] = new Coordinate(X, Y);

                return new Coordinate(X + 1, Y, parents);
            }

            /// <summary>
            /// 往上走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveUp()
            {
                Coordinate[] parents = new Coordinate[Path.Count + 1];
                Path.CopyTo(parents);
                parents[^1] = new Coordinate(X, Y);
                return new Coordinate(X, Y - 1, parents);
            }

            /// <summary>
            /// 往下走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveDown()
            {
                Coordinate[] parents = new Coordinate[Path.Count + 1];
                Path.CopyTo(parents);
                parents[^1] = new Coordinate(X, Y);
                return new Coordinate(X, Y + 1, parents);
            }
        }

        /// <summary>
        /// 地图
        /// </summary>
        private readonly char[][] map = { };
        /// <summary>
        /// 可通行的道路
        /// </summary>
        public const char ROAD = '.';
        /// <summary>
        /// 障碍物
        /// </summary>
        public const char BARRIER = '#';
        /// <summary>
        /// 开始坐标
        /// </summary>
        public readonly Coordinate Start_Coordinate;
        /// <summary>
        /// 目标坐标
        /// </summary>
        public readonly Coordinate Target_Coordinate;
        /// <summary>
        /// 等待队列
        /// </summary>
        private Queue<Coordinate> Waiter;
        /// <summary>
        /// 行数
        /// </summary>
        private readonly int Rows;
        /// <summary>
        /// 列数
        /// </summary>
        private readonly int Columns;
        /// <summary>
        /// 经过的坐标标记
        /// </summary>
        private HashSet<Coordinate> Book { get; set; }
        /// <summary>
        /// 最短路径
        /// </summary>
        private Coordinate Path { get; set; }
        /// <summary>
        /// 是否能达到目的
        /// </summary>
        private bool IsFinded = false;

        private Labyrinth(char[][] map, Coordinate startCoordinate, Coordinate targetCoordinate)
        {
            if (map is null || map.Length < 1)
                throw new ArgumentException("必须设置地图");

            this.map = map;
            Start_Coordinate = startCoordinate;
            Target_Coordinate = targetCoordinate;

            Rows = map.Length;
            Columns = map[0].Length;

            Path = new Coordinate(0, 0)
            { 
                Step = Rows * Columns
            };
            int capacity = Rows * Columns / 2;

            Waiter = new Queue<Coordinate>(capacity);
            Book = new HashSet<Coordinate>(capacity);
        }
        /// <summary>
        /// 新建一个迷宫
        /// </summary>
        /// <param name="map">地图</param>
        /// <param name="startCoordinate">开始坐标</param>
        /// <param name="targetCoordinate">目标坐标</param>
        /// <returns></returns>
        public static Labyrinth New(char[][] map, Coordinate startCoordinate, Coordinate targetCoordinate)
        {
            return new Labyrinth(map, startCoordinate, targetCoordinate);
        }

        /// <summary>
        /// 搜索路径
        /// </summary>
        /// <returns>(是否可以达到目的, 达到目的最小路径)</returns>
        public (bool, Coordinate) Search()
        {
            Waiter.Enqueue(Start_Coordinate);
            SearchMinimumPath();
            return (IsFinded, Path);
        }

        /// <summary>
        /// 搜索最小路径
        /// </summary>
        /// <param name="currentCoordinate">当前坐标</param>
        /// <param name="step">已经走了几步</param>
        /// <returns>是否有找到最小路径</returns>
        private void SearchMinimumPath()
        {
            if (Waiter.Count == 0)
                return;
            var currentCoordinate = Waiter.Dequeue();
            Book.Add(currentCoordinate);

            if (currentCoordinate.Equals(Target_Coordinate))
            {
                //  更新最小路径记录
                if (currentCoordinate.Step < Path.Step)
                {
                    IsFinded = true;
                    Path = currentCoordinate;
                    return;
                }
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                Coordinate nextCoordinate = i switch
                { 
                    0 => currentCoordinate.MoveUp(),
                    1 => currentCoordinate.MoveRight(),
                    2 => currentCoordinate.MoveDown(),
                    3 => currentCoordinate.MoveLeft(),
                    _ => throw new ArgumentException()
                };

                if (Book.Contains(nextCoordinate) || map[nextCoordinate.X][nextCoordinate.Y] == BARRIER
                || nextCoordinate.X < 0 || nextCoordinate.X > Rows
                || nextCoordinate.Y < 0 || nextCoordinate.Y > Columns)
                    continue;

                Waiter.Enqueue(nextCoordinate);
            }

            SearchMinimumPath();
        }
    }
}
