namespace ArrayClassDemo
{
    public class IntArray : Array<int>
    {
        public IntArray()
        {
            
        }
        public IntArray(int[] array) : base(array)
        {
            
        }
        public int Sum()
        {
            var s = 0;
            for (var i = 0; i < Length; i++)
                s += this[i];
            return s;
        }
        
    }
}