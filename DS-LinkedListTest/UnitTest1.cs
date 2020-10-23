using Microsoft.VisualStudio.TestTools.UnitTesting;
using DS_LinkedList;

namespace DS_LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Inserting_Element_After_Particular_Should_Display_Desired_LinkedList()
        {
            int node1 = 56, node2 = 30, node3 = 40, node4 = 70;
            LinkedList linkedList = new LinkedList();
            linkedList.Append(node1);
            linkedList.Append(node2);
            linkedList.Append(node3);
            linkedList.Append(node4);
            int expected = node3;
            int actual = linkedList.DeleteGivenNode(node3).data;
            Assert.AreEqual(expected, actual);
        }
    }
}
