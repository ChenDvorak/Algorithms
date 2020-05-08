using Algorithms.DeepFirstSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest
{
    /// <summary>
    /// 测试深度优先搜索
    /// </summary>
    [TestClass]
    public class DFSTest
    {
        /// <summary>
        /// 测试走迷宫
        /// </summary>
        [TestMethod]
        public void TestLabyrinth()
        {
            char[][] map = new char[][] {
                new char[] {'#', '#', '#', '#', '#', '#', '#', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '#', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '.', '.', '#', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '#', '.', '#' },
                new char[] {'#', '.', '.', '.', '.', '.', '.', '#' },
                new char[] {'#', '#', '#', '#', '#', '#', '#', '#' },
            };

            var startCooridnate = new Labyrinth.Coordinate(1, 1);
            var endCooridnate = new Labyrinth.Coordinate(7, 6);

            var labyrinth = Labyrinth.New(map, startCooridnate, endCooridnate);
            //  即使只是 8 * 9 的地图，搜索的效率也十分低下
            (bool isFind, Labyrinth.Coordinate[] path) = labyrinth.Search();
            Assert.IsTrue(isFind);
            //  输出路径
            for (int i = path.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{path[i].ToString()} ");
            }
        }
    }
}
