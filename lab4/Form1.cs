using System.Data;
using System.Formats.Asn1;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace lab4
{
    public partial class Form1 : Form
    {
        private bool isDoubleClick = false;
        private List<TreeNode> checkedNodes = new List<TreeNode>();
        private TreeNode lastSelected = new TreeNode();

        List<DecisionMakingNodes> rules = new List<DecisionMakingNodes>();

        MuscleNode muscleNode = new MuscleNode();
        IsMuscleNode isMuscleNode = new IsMuscleNode();
        ExercizeNode exercizeNode = new ExercizeNode();
        ExBasicNode armsBasicNode = new ExBasicNode();
        ExBasicNode legsBasicNode = new ExBasicNode();
        ExBasicNode absBasicNode = new ExBasicNode();
        ExBasicNode backBasicNode = new ExBasicNode();
        CardioNode cardioNode = new CardioNode();
        ExBasicNode cardioExNode = new ExBasicNode();
        BackFWNode backFWNode = new BackFWNode();
        BackTANode backTANode = new BackTANode();
        ArmsFWNode armsFWNode = new ArmsFWNode();
        ArmsTANode armsTANode = new ArmsTANode();
        LegsFWNode legsFWNode = new LegsFWNode();
        LegsTANode legsTANode = new LegsTANode();
        AbsFWNode absFWNode = new AbsFWNode();
        AbsTANode absTANode = new AbsTANode();
        ArmsIsNode armsIs = new ArmsIsNode();
        LegsIsNode legsIs = new LegsIsNode();
        LegsFWExerNode legsFWExerNode = new LegsFWExerNode();
        LegsTAExerNode legsTAExerNode = new LegsTAExerNode();
        ArmsFWExerNode armsFWExerNode = new ArmsFWExerNode();
        ArmsTAExerNode armsTAExerNode = new ArmsTAExerNode();
        BackFWExerNode backFWExerNode = new BackFWExerNode();
        BackTAExerNode backTAExerNode = new BackTAExerNode();
        ArmsIsExerNode armsIsExerNode = new ArmsIsExerNode();
        LegsIsExerNode legsIsExerNode = new LegsIsExerNode();

        public Form1()
        {
            InitializeComponent();
            treeView1.CheckBoxes = true;
            fillNodes();
            treeView1.Update();
            treeView1.Nodes[0].Expand();
        }

        private void fillNodes()
        {
            rules.Add(muscleNode);
            rules.Add(isMuscleNode);
            rules.Add(exercizeNode);
            rules.Add(armsBasicNode);
            rules.Add(legsBasicNode);
            rules.Add(absBasicNode);
            rules.Add(backBasicNode);
            rules.Add(cardioNode);
            rules.Add(backFWNode);
            rules.Add(backTANode);
            rules.Add(armsFWNode);
            rules.Add(armsTANode);
            rules.Add(legsFWNode);
            rules.Add(legsTANode);
            rules.Add(armsIsExerNode);
            rules.Add(legsIsExerNode);

            rules.Add(absFWNode);
            rules.Add(absTANode);

            rules.Add(armsIs);
            rules.Add(legsIs);
            rules.Add(legsFWExerNode);
            rules.Add(backTAExerNode);
            rules.Add(legsTAExerNode);
            rules.Add(backFWExerNode);
            rules.Add(armsTAExerNode);
            rules.Add(armsFWExerNode);
            rules.Add(cardioExNode);

            for(int i = 0; i < rules.Count; ++i)
                rules[i].fillNodes("D:/exercizes.txt");

            addNodes(treeView1.Nodes[0], exercizeNode);
            addNodes(treeView1.Nodes[0].Nodes[0], muscleNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[0], armsBasicNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[1], legsBasicNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[2], absBasicNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[3], backBasicNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[4], cardioExNode);

            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[2].Nodes[0], absFWNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[2].Nodes[1], absTANode);

            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[0], armsFWNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[1], armsTANode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes[0], legsFWNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes[1], legsTANode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[3].Nodes[0], backFWNode);
            addNodes(treeView1.Nodes[0].Nodes[0].Nodes[3].Nodes[1], backTANode);
            addNodes(treeView1.Nodes[0].Nodes[1], isMuscleNode);
            addNodes(treeView1.Nodes[0].Nodes[1].Nodes[0], armsIs);
            addNodes(treeView1.Nodes[0].Nodes[1].Nodes[1], legsIs);
            addForEachNode(treeView1.Nodes[0].Nodes[1].Nodes[0], armsIsExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[1].Nodes[1], legsIsExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[0], armsFWExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[1], armsTAExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes[0], legsFWExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes[1], legsTAExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[4], cardioNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[3].Nodes[0], backFWExerNode);
            addForEachNode(treeView1.Nodes[0].Nodes[0].Nodes[3].Nodes[1], backTAExerNode);

            lastSelected = treeView1.Nodes[0];
        }


        private void addNodes(TreeNode parent, DecisionMakingNodes source)
        {
            for (int i = 0; i < source.Count(); ++i)
            {
                parent.Nodes.Add(source.CurNode(i));
            }
        }

        private void addForEachNode(TreeNode parent, DecisionMakingNodes sourse)
        {
            for(int i = 0; i < sourse.Count(); ++i)
            {
                if (parent.Nodes[i]!= null)
                {
                    parent.Nodes[i].Nodes.Add(sourse.CurNode(i));
                }
            }
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (isDoubleClick && e.Action == TreeViewAction.Collapse)
                e.Cancel = true;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (isDoubleClick && e.Action == TreeViewAction.Expand)
                e.Cancel = true;
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            isDoubleClick = e.Clicks > 1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Checked && treeView1.SelectedNode.Level > lastSelected.Level)
            {
                if (checkedNodes.Count == 1)
                {
                    treeView1.SelectedNode.Expand();
                    lastSelected = treeView1.SelectedNode;
                    if (treeView1.SelectedNode.Nodes.Count == 0)
                    {
                        textBox1.Text = treeView1.SelectedNode.Text;
                        pictureBox1.Image = Image.FromFile("C:/pictures/"+ treeView1.SelectedNode.Text+".jpg");
                    }
                    treeView1.SelectedNode.Checked = false;
                    checkedNodes.Clear();
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node!.Checked == true)
            {
                if (checkedNodes.Count > 0) e.Node!.Checked = false;
                else checkedNodes.Add(e.Node!);
            } else if(e.Node!.Checked == false)
            {
                checkedNodes.Remove(e.Node!);
            }
            /*if(checkedNodes.Count > 1 && e.Node!.Checked)
            {
                for (int i = 0; i < checkedNodes.Count; i++)
                    checkedNodes[i].Checked = false;
                checkedNodes.Clear();
                checkedNodes.Add(e.Node!);
            }
            
            if (e.Node! == treeView1.SelectedNode)
                treeView1_AfterSelect(sender, e);*/
        }
    }
}