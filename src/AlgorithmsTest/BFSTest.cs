using Algorithms.BreadthFilstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest
{
    /// <summary>
    /// 测试深度优先搜索
    /// </summary>
    [TestClass]
    public class BFSTest
    {
        /// <summary>
        /// 测试使用深度优先搜索走迷宫
        /// </summary>
        [TestMethod]
        public void TestLabyrinth()
        {
            //  这个地图要跑 5 秒
            char[][] map = new char[][] {
                new char[] {'#', '#', '#', '#', '#', '#', '#', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '#', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '#', '#', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '#', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '#', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '#', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '#', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '#', '#', '#', '#', '#', '#', '#' },
            };

            var startCoordinate = new Labyrinth.Coordinate(1, 1);
            var endCoordinate = new Labyrinth.Coordinate(17, 6);

            var labyrinth = Labyrinth.New(map, startCoordinate, endCoordinate);
            
            (bool isFind, Labyrinth.Coordinate path) = labyrinth.Search();
            Assert.IsTrue(isFind);

            //  打印结果
            //  输出路径
            Console.WriteLine($"最短步数为：{path.Step}");

            for (int i = 0; i < path.Path.Count; i++)
            {
                Console.Write($"{path.Path[i]} ");
            }
            Console.WriteLine(path);

            //  打印地图
            foreach (var item in path.Path)
            {
                map[item.X][item.Y] = '●';
            }
            map[path.X][path.Y] = '●';
            map[startCoordinate.X][startCoordinate.Y] = 'S';
            map[endCoordinate.X][endCoordinate.Y] = 'E';
            foreach (var rows in map)
            {
                foreach (var column in rows)
                {
                    if (column == Labyrinth.ROAD)
                        Console.Write($" {column}");
                    else
                        Console.Write(column);
                }
                Console.WriteLine();
            }
        }
    }
}
