namespace Deck_Shuffle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StratUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] mixing = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var mixingLeft = new Queue<int>();
            var mixingRight = new Queue<int>();
            var carDeck = new Queue<int>();
            int rest = 0;

            for (int i = 0; i < number; i++)
            {
                carDeck.Enqueue(i + 1);
            }
            for (int i = 0; i < mixing.Length; i++)
            {
                if (!(mixing[i] == 0))
                {
                    for (int j = 1; j <= mixing[i]; j++)
                    {
                        mixingLeft.Enqueue(carDeck.Dequeue());
                    }
                    rest = carDeck.Count();
                    for (int l = 0; l < rest; l++)
                    {
                        mixingRight.Enqueue(carDeck.Dequeue());
                    }
                    while (!(mixingLeft.Count == 0 || mixingRight.Count == 0))
                    {

                        if (mixingLeft.Count > mixingRight.Count)
                        {
                            carDeck.Enqueue(mixingLeft.Dequeue());
                            carDeck.Enqueue(mixingRight.Dequeue());

                        }
                        else
                        {
                            carDeck.Enqueue(mixingLeft.Dequeue());
                            carDeck.Enqueue(mixingRight.Dequeue());

                        }
                    }
                    if (mixingRight.Count == 0)
                    {
                        rest = mixingLeft.Count();
                        for (int k = 0; k < rest; k++)
                        {
                            carDeck.Enqueue(mixingLeft.Dequeue());
                        }
                    }
                    else
                    {
                        rest = mixingRight.Count();
                        for (int k = 0; k < rest; k++)
                        {
                            carDeck.Enqueue(mixingRight.Dequeue());
                        }
                    }
                }
            }
            rest = carDeck.Count();
            for (int i = 0; i < rest; i++)
            {
                Console.Write((carDeck.Dequeue())+" ");
            }
            //Console.WriteLine(string.Join(' ',carDeck.Dequeue()));
        }
    }
}
