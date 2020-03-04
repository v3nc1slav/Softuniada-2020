namespace Path
{
    using System;
    using System.Collections.Generic;

    class StratUp
    {
        static void Main(string[] args)
        {
            char[] path = Console.ReadLine().ToCharArray();
            char[] pathNew = path;
            var result = new List<char[]>();
            int v = 0;
            double pow = 0;
            int number = 1;


            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '*')
                {
                    v++;
                }
            }
            if (v > 0)
            {
                pow = Math.Pow(3, v);
                for (int i = 0; i < pow; i++)
                {
                    newSart:
                    pathNew = path;
                    for (int j = 0; j < pathNew.Length; j++)
                    {
                        if (pathNew[j] == '*')
                        {
                            pathNew[j] = 'L';
                            for (int k = j + 1; k < pathNew.Length; k++)
                            {
                                if (pathNew[k] == '*')
                                {
                                    pathNew[k] = 'L';
                                    if (result.Contains(pathNew))
                                    {
                                        pathNew[k] = 'S';
                                        if (result.Contains(pathNew))
                                        {
                                            pathNew[k] = 'R';
                                            if (result.Contains(pathNew))
                                            {
                                                goto nextS;
                                            }
                                            result.Add(pathNew);
                                        }
                                        else
                                        {
                                            result.Add(pathNew);
                                        }
                                    }
                                    else
                                    {
                                        result.Add(pathNew);
                                        goto newSart;
                                    }
                                }
                            }
                        nextS:
                            pathNew[j] = 'S';
                            for (int k = pathNew[j] + 1; k < pathNew.Length; k++)
                            {
                                if (pathNew[j] == '*')
                                {
                                    pathNew[j] = 'L';
                                    if (result.Contains(pathNew))
                                    {
                                        pathNew[j] = 'S';
                                        if (result.Contains(pathNew))
                                        {
                                            pathNew[j] = 'R';
                                            if (result.Contains(pathNew))
                                            {
                                                goto nextR;
                                            }
                                            result.Add(pathNew);
                                        }
                                        else
                                        {
                                            result.Add(pathNew);
                                        }
                                    }
                                    else
                                    {
                                        result.Add(pathNew);
                                    }
                                }
                            }
                        nextR:
                            for (int k = pathNew[j] + 1; k < pathNew.Length; k++)
                            {
                                if (pathNew[j] == '*')
                                {
                                    pathNew[j] = 'L';
                                    if (result.Contains(pathNew))
                                    {
                                        pathNew[j] = 'S';
                                        if (result.Contains(pathNew))
                                        {
                                            pathNew[j] = 'R';
                                            result.Add(pathNew);
                                        }
                                        else
                                        {
                                            result.Add(pathNew);
                                        }
                                    }
                                    else
                                    {
                                        result.Add(pathNew);
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else
            {
                pow = 1;
                result.Add(path);
            }

            Console.WriteLine(pow);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
