using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace lab4
{
    public class DecisionMakingNodes
    {
        protected string className = "";
        protected List<TreeNode> nodes = new List<TreeNode>();

        public DecisionMakingNodes()
        {
            className = "DecisionMakingNode";
        }

        public void fillNodes(string fileName)
        {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fileName);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null && line != (className.Substring(0, className.Length-4) + "{"))
                {
                    line = sr.ReadLine();
                }
                if (line == null)
                {
                    Console.WriteLine("There is not such class.\n");
                    return;
                }
                line = sr.ReadLine();
                while (line != "}")
                {
                    TreeNode tr = new TreeNode();
                    tr.Text = line;
                    nodes.Add(tr);
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public TreeNode CurNode(int i)
        {
            return nodes[i];
        }

        public int Count()
        {
            return nodes.Count();
        }
    }


    public class MuscleNode : DecisionMakingNodes
    {
        public MuscleNode()
        {
            className = "MuscleNode";
        }
          

    }

    public class IsMuscleNode : DecisionMakingNodes
    {
        public IsMuscleNode()
        {
            className = "IsMuscleNode";
        }
    }

    public class ExercizeNode : DecisionMakingNodes
    {
        public ExercizeNode()
        {
            className = "ExercizeNode";
        }

    }

    public class ExBasicNode: DecisionMakingNodes
    {
        public ExBasicNode()
        {
            className = "ExBasicNode";
        }

    }
    public class CardioNode : DecisionMakingNodes
    {
        public CardioNode()
        {
            className = "CardioNode";
        }

    }

    public class LegsFWNode : DecisionMakingNodes
    {
        public LegsFWNode()
        {
            className = "LegsFWNode";
        }
    }

    public class LegsTANode : DecisionMakingNodes
    {
        public LegsTANode()
        {
            className = "LegsTANode";
        }

    }

    public class ArmsFWNode : DecisionMakingNodes
    {
        public ArmsFWNode()
        {
            className = "ArmsFWNode";
        }

    }

    public class ArmsTANode : DecisionMakingNodes
    {
        public ArmsTANode()
        {
            className = "ArmsTANode";
        }

    }

    public class BackTANode : DecisionMakingNodes
    {
        public BackTANode()
        {
            className = "BackTANode";
        }
    }

    public class BackFWNode : DecisionMakingNodes
    {
        public BackFWNode()
        {
            className = "BackFWNode";
        }
    }

    public class AbsFWNode : DecisionMakingNodes
    {
        public AbsFWNode()
        {
            className = "AbsFWNode";
        }
    }

    public class AbsTANode : DecisionMakingNodes
    {
        public AbsTANode()
        {
            className = "AbsTANode";
        }
    }

    public class ArmsIsNode : DecisionMakingNodes
    {
        public ArmsIsNode()
        {
            className = "ArmsIsNode";
        }

    }

    public class LegsIsNode : DecisionMakingNodes
    {
        public LegsIsNode()
        {
            className = "LegsIsNode";
        }

    }

    public class LegsFWExerNode : DecisionMakingNodes
    {
        public LegsFWExerNode()
        {
            className = "LegsFWExerNode";
        }

    }

    public class LegsTAExerNode : DecisionMakingNodes
    {
        public LegsTAExerNode()
        {
            className = "LegsTAExerNode";
        }

    }

    public class ArmsTAExerNode : DecisionMakingNodes
    {
        public ArmsTAExerNode()
        {
            className = "ArmsTAExerNode";
        }
    }

    public class BackTAExerNode : DecisionMakingNodes
    {
        public BackTAExerNode()
        {
            className = "BackTAExerNode";
        }
    }

    public class BackFWExerNode : DecisionMakingNodes
    {
        public BackFWExerNode()
        {
            className = "BackFWExerNode";
        }
    }

    public class ArmsFWExerNode : DecisionMakingNodes
    {
        public ArmsFWExerNode()
        {
            className = "ArmsFWExerNode";
        }
    }

    public class ArmsIsExerNode : DecisionMakingNodes
    {
        public ArmsIsExerNode()
        {
            className = "ArmsIsExerNode";
        }
    }

    public class LegsIsExerNode : DecisionMakingNodes
    {
        public LegsIsExerNode()
        {
            className = "LegsIsExerNode";
        }
    }

}
