namespace laba6
{
    public class Node
    {
        public double data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(double data)
        {
            this.data = data;
            left = right = null;
        }
    }
}