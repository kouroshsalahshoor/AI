namespace AI.ClassLibrary
{
    public class OrderedArray(int Capacity, int LastPosition = -1)
    {
        public int[] Values { get; set; } = new int[Capacity];

        public void Print()
        {
            if (LastPosition == -1)
            {
                Console.WriteLine("The Array is Empty");
            }
            else
            {
                for (int i = 0; i <= LastPosition; i++)
                {
                    Console.WriteLine($"Pos: {i} - Value: {Values[i]}");
                }
            }
        }

        public void Insert(int value)
        {
            if (LastPosition == Capacity - 1)
            {
                Console.WriteLine("Max Capacity has been reached");
                return;
            }

            int positionForInsert = 0;
            for (int i = 0; i <= LastPosition; i++)
            {
                positionForInsert = i;

                if (Values[i] > value)
                {
                    break;
                }

                if (i == LastPosition)
                {
                    positionForInsert = i + 1;
                }
            }

            //push right
            var lastPosition = LastPosition;
            while (lastPosition >= positionForInsert)
            {
                Values[lastPosition + 1] = Values[lastPosition];
                lastPosition = lastPosition - 1;
            }

            Values[positionForInsert] = value;
            LastPosition = LastPosition + 1;
        }
    }
}
