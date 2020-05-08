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
            public Coordinate(int x, int y, Coordinate[] path)
            {
                X = x;
                Y = y;
                Path = new List<Coordinate>(path.Length + 1);
                Path.AddRange(path);
                Path.Add(new Coordinate(x, y, Array.Empty<Coordinate>()));
            }

            public List<Coordinate> Path { get; set; }

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
            internal Coordinate MoveLeft() => new Coordinate(X - 1, Y, Path.ToArray());
            /// <summary>
            /// 往右走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveRight() => new Coordinate(X + 1, Y, Path.ToArray());
            /// <summary>
            /// 往上走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveUp() => new Coordinate(X, Y - 1, Path.ToArray());
            /// <summary>
            /// 往下走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveDown() => new Coordinate(X, Y + 1, Path.ToArray());
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
        private Queue<Coordinate> Que;
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
        private Coordinate[] Path { get; set; }
        /// <summary>
        /// 最小步数
        /// </summary>
        private int MinimumStep;

        private Labyrinth(char[][] map, Coordinate startCoordinate, Coordinate targetCoordinate)
        {
            if (map is null || map.Length < 1)
                throw new ArgumentException("必须设置地图");

            this.map = map;
            Start_Coordinate = startCoordinate;
            Target_Coordinate = targetCoordinate;

            Rows = map.Length;
            Columns = map[0].Length;
            MinimumStep = Rows * Columns;

            int capacity = MinimumStep / 2;
            Que = new Queue<Coordinate>(capacity);
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
        public (bool, Coordinate[]) Search()
        {
            SearchMinimumPath(Start_Coordinate, 0);
            if (MinimumStep < 0)
                return (false, Array.Empty<Coordinate>());
            return (true, Path);
        }

        /// <summary>
        /// 搜索最小路径
        /// </summary>
        /// <param name="currentCoordinate">当前坐标</param>
        /// <param name="step">已经走了几步</param>
        /// <returns>是否有找到最小路径</returns>
        private bool SearchMinimumPath(Coordinate currentCoordinate, int step)
        {
            if (currentCoordinate.Equals(Target_Coordinate))
            {
                //  更新最小路径记录
                if (step < MinimumStep)
                {
                    MinimumStep = step;

                    return true;
                }
                return false;
            }

            
        }
    }
}
