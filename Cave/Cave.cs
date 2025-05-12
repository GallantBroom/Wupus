namespace Cave
{
    public class Cave
    {
        //public int CaveNumber { get; set; }
        //Cave1[] cave1 = new Cave1[30];
        //Cave1[] cave2 = new Cave1[30];
        //Cave1[] cave3 = new Cave1[30];
        //Cave1[] cave4 = new Cave1[30];
        //Cave1[] cave5 = new Cave1[30];
        int[,] Cave1 = {{ 6, 7, 30 }, { 3, 0, 0 }, { 2, 26, 4 }, { 3, 10, 0 }, { 29, 0, 0 }, { 1, 12, 0 }, { 1, 8, 0 }, { 7, 13, 9 }, { 8, 15, 0 }, { 4, 11, 0 }, { 10, 17, 0 }, { 6, 0, 0 }, { 8, 0, 0 }, { 19, 0, 0 }, { 9, 16, 0 }, { 15, 21, 0 }, { 11, 18, 22 }, { 17, 24, 0 }, { 14, 25, 30 }, { 21, 0, 0 }, { 16, 20, 22 }, { 17, 21, 27 }, { 24, 28, 29 }, { 23, 18, 0 }, { 19, 26, 0 }, { 3, 25, 27 }, { 22, 26, 28 }, { 23, 27, 0 }, { 5, 23, 0 }, { 1, 19, 0 }};
        public int[] GiveCave(int caveNumber, int roomNumber)
        {
            List<int> dat = new List<int>();
            for(int i = 0; i < 3;  i++)
            {
                //if (Cave1[roomNumber, i] != 0)
                //{
                dat.Add(Cave1[roomNumber, i]);
                //}                dat.Add(Cave1[roomNumber, i]);
            }
            return dat.ToArray();
        }
    }
}
