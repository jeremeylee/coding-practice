using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSharp.Graph
{
    class CourseSchedule
    {
        public class Solution
        {
            public bool CanFinish(int numCourses, int[][] prerequisites)
            {
                int[] indegree = new int[numCourses];
                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < prerequisites.Length; i++)
                {
                    indegree[prerequisites[i][0]]++;
                }

                for (int i = 0; i < numCourses; i++)
                {
                    if (indegree[i] == 0)
                    {
                        queue.Enqueue(i);
                    }
                }
                int count = queue.Count;

                while (queue.Count != 0)
                {
                    int prerequisite = queue.Dequeue();
                    for (int i = 0; i < prerequisites.Length; i++)
                    {
                        if (prerequisites[i][1] == prerequisite)
                        {
                            indegree[prerequisites[i][0]]--;
                            if (indegree[prerequisites[i][0]] == 0)
                            {
                                count++;
                                queue.Enqueue(prerequisites[i][0]);
                            }
                        }

                    }
                }

                return count == numCourses;
            }
        }
    }
}
