using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_LinkedList;

namespace DS_LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Input_Element_to_Search_Should_Return_Element_If_Exists()
        {
            int node1 = 56, node2 = 30, node3 = 70;
            LinkedList linkedList = new LinkedList();
            linkedList.Append(node1);
            linkedList.Append(node2);
            linkedList.Append(node3);
            int expexted = node2;
            int actual = linkedList.Search(node2).data;
            Assert.AreEqual(expexted, actual);
        }
    }
}
