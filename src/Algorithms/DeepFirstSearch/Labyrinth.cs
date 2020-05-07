/*
 * 使用深度优先搜索探索迷宫
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DeepFirstSearch
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

            public override string ToString()
            {
                return $"{X},{Y}";
            }

            /// <summary>
            /// 往左走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveLeft()
            {
                return new Coordinate
                {
                    X = X - 1,
                    Y = Y
                };
            }
            /// <summary>
            /// 往右走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveRight()
            {
                return new Coordinate
                {
                    X = X + 1,
                    Y = Y
                };
            }
            /// <summary>
            /// 往上走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveUp()
            {
                return new Coordinate
                {
                    X = X,
                    Y = Y - 1
                };
            }
            /// <summary>
            /// 往下走，获取下一个坐标
            /// </summary>
            /// <returns>新坐标</returns>
            internal Coordinate MoveDown()
            {
                return new Coordinate
                {
                    X = X,
                    Y = Y + 1
                };
            }
        }

        /// <summary>
        /// 地图
        /// </summary>
        private readonly char[][] map = {};
        /// <summary>
        /// 可通行的道路
        /// </summary>
        private const char ROAD = '.';
        /// <summary>
        /// 障碍物
        /// </summary>
        private const char BARRIER = '#';
        /// <summary>
        /// 目标
        /// </summary>
        private const char TARGET = '0';
        /// <summary>
        /// 开始坐标
        /// </summary>
        public readonly Coordinate Start_Coordinate;
        /// <summary>
        /// 目标坐标
        /// </summary>
        public readonly Coordinate Target_Coordinate;
        /// <summary>
        /// 经过的坐标标记
        /// </summary>
        private HashSet<string> Book { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        private List<Coordinate> Path { get; set; }                         

        public bool IsPass(Coordinate coordinate) => Book.Contains(coordinate.ToString());

        private Labyrinth(char[][] map, Coordinate startCoordinate, Coordinate targetCoordinate)
        {
            if (map is null || map.Length < 1)
                throw new ArgumentException("必须设置地图");

            this.map = map;
            Start_Coordinate = startCoordinate;
            Target_Coordinate = targetCoordinate;

            int capacity = map.Length * map[0].Length / 2;
            Book = new HashSet<string>(capacity);
            Path = new List<Coordinate>(capacity);
        }
        /// <summary>
        /// 新建一个迷宫
        /// </summary>
        /// <param name="map">地图</param>
        /// <param name="startCoordinate">开始坐标</param>
        /// <param name="targetCoordinate">目标坐标</param>
        /// <returns></returns>
        public Labyrinth New(char[][] map, Coordinate startCoordinate, Coordinate targetCoordinate)
        {
            return new Labyrinth(map, startCoordinate, targetCoordinate);
        }

        /// <summary>
        /// 搜索路径
        /// </summary>
        /// <returns>(是否可以达到目的, 达到目的最小路径)</returns>
        public (bool, Coordinate[]) Search()
        {


            throw new NotImplementedException();
        }
    }
}
