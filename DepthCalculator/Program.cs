namespace DepthCalculator
{
    class Branch
    {
        public List<Branch> branches;
        public Branch()
        {
            branches = new List<Branch>();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Test.
            Branch branch = new();
            branch.branches.Add(new());

            Branch branch2 = new();
            branch2.branches.Add(branch);
            branch2.branches.Add(new());

            Console.WriteLine(CalculateDepth(branch2)); // 3.
        }

        // Recursively finds the depth of a Branch structure.
        static int CalculateDepth(Branch branch)
        {
            // Base case.
            if (branch.branches.Count == 0)
            {
                return 1;
            }

            // Get the sub branch with the highest depth.
            int highestDepth = CalculateDepth(branch.branches[0]);
            for (int i = 1; i < branch.branches.Count; i++)
            {
                int depth = CalculateDepth(branch.branches[i]);
                if (depth > highestDepth)
                {
                    highestDepth = depth;
                }
            }

            return 1 + highestDepth;
        }
    }
}