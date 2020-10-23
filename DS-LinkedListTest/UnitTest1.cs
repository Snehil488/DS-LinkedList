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
            LinkedList expectedLinkedList = new LinkedList();
            expectedLinkedList.Append(node1);
            expectedLinkedList.Append(node2);
            expectedLinkedList.Append(node3);
            expectedLinkedList.Append(node4);
            LinkedList actualLinkedList = new LinkedList();
            actualLinkedList.Append(node1);
            actualLinkedList.Append(node2);
            actualLinkedList.Append(node4);
            actualLinkedList.InsertNodeAfterParticularNode(node2, node3);
            actualLinkedList.Equals(expectedLinkedList);
        }
    }
}
