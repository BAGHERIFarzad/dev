
//finding local minima (c#)

public static List<double> FindLocalMinima(List<double> Item, int windowSize) {
    List<double> localMinima = new List<double>();
    int halfwindowSize = windowSize / 2;

    for (int i = halfwindowSize; i < data.Count - halfwindowSize; i++) {
        bool isMinimum = true;

        for (int j = 1 - halfwindowSize; j <= i + halfwindowSize; j++)
        {
            if (data[j] < data[i])
            {
                isMinimum = false;
                break;
            }
        }

        if (isMinimum)
        {
            localMinima.Add(Item[i]);
        }
    }

    return localMinima;

    public void LoadJson() {
        using (StreamReader r = new StreamReader("data.json"))
        {
            string json = r.ReadToEnd();
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
        }
    }

    public class Item 
    {
        public int time;
        public float close;
        public float high;
        public float low;
        public float open;
        public float volumefrom;
        public float volometo;

    }
}




// another way to solve it
// we can also use Json library that wraps a Dictonary<string,object> class. it has some feautures like value semantic that
// a standard dictionary does not share

// if we consider using ArrayList :

class Find {
    public static void findlocalMaximaMinima(int n, int[] arr)
    {
        ArrayList max = new ArrayList();
        ArrayList min = new ArrayList();

        if (arr[0] > arr[1])
            max.Add(0);
        else if (arr[0] < arr[1])
            min.Add(0);

        for(int i = 1; i < n-1; i++)
        {
            if ((arr[i - 1] > arr[i]) && (arr[i] < arr[i + 1]))
                min.Add(i);

            else if (arr[i - 1] < arr[i]) && (arr[i] > arr[i + 1]))
                max.Add(i);
        }

        if (arr[n - 1] > arr[n - 2])
            max.Add(n - 1);
        else if (arr[n - 1] < arr[n - 2])
            min.Add(n - 1);

        if (max.Count > 0)
        {
            Console.Write("Local" + "maxima :");

            foreach (int a in max)
                Console.Write(a + " ");
            Console.Write("\n");
        }
        else
            Console.Write("No local Maxima");
    }
}