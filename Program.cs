internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap mot so: ");
        int so = int.Parse(Console.ReadLine());

        if (0 <= so && so <= 999)
        {
            if (so < 10)
            {
                Console.WriteLine(DocSo(so));
            }
            else if (so < 20)
            {
                Console.WriteLine(DocSoMuoi(so));
            }
            else if (so < 100)
            {
                int chuc = so / 10;
                int donvi = so % 10;
                Console.Write(DocHangChuc(chuc) + " ");
                if (donvi > 0)
                    Console.WriteLine(DocSo(donvi));
                else
                    Console.WriteLine("Muoi");
            }
        }
        else
        {
            Console.WriteLine("Nhap sai gia tri, vui long nhap lai.");
        }
    }

    // Hàm đọc các số đơn
    static string DocSo(int so)
    {
        return so switch
        {
            0 => "Khong",
            1 => "Mot",
            2 => "Hai",
            3 => "Ba",
            4 => "Bon",
            5 => "Nam",
            6 => "Sau",
            7 => "Bay",
            8 => "Tam",
            9 => "Chin",
            _ => ""
        };
    }

    // Hàm đọc các số từ 10 đến 19
    static string DocSoMuoi(int so)
    {
        return so switch
        {
            10 => "Muoi",
            11 => "Muoi Mot",
            12 => "Muoi Hai",
            13 => "Muoi Ba",
            14 => "Muoi Bon",
            15 => "Muoi Nam",
            16 => "Muoi Sau",
            17 => "Muoi Bay",
            18 => "Muoi Tam",
            19 => "Muoi Chin",
            _ => ""
        };
    }

    // Hàm đọc các số hàng chục (20, 30, ..., 90)
    static string DocHangChuc(int so)
    {
        return so switch
        {
            1 => "Muoi",
            2 => "Hai Muoi",
            3 => "Ba Muoi",
            4 => "Bon Muoi",
            5 => "Nam Muoi",
            6 => "Sau Muoi",
            7 => "Bay Muoi",
            8 => "Tam Muoi",
            9 => "Chin Muoi",
            _ => ""
        };
    }
}
