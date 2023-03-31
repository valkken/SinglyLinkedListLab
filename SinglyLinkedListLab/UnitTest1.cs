namespace SinglyLinkedListLab
{
    public class Tests
    {
        private LinkedList sll;
        [SetUp]
        public void SetUp()
        {
            sll = new LinkedList();
        }

        [Test]
        public void TestPrependingToEmptyList()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            //Assert that it was added or the SLL is bigger
            Assert.IsNotNull(sll.Head);     

            //Assert that the size is 1
            Assert.AreEqual(1, sll.Count);      

            //Assert that th efirst node value is "Joe Blow"
            Node first = sll.Head;

            string value = first.Value;
            Assert.AreEqual("Joe Blow", value);

            //Assert there's no next of first node

            Assert.IsNull(first.Next);

            Console.WriteLine(sll);
        }

        [Test]
        public void TestPrependingToNonEmptyList()
        {
            sll.AddFirst("Joe Blow");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Sam Sammerson");

            string name = "Dave Daverson";
            
            sll.AddFirst(name);

            //Assert that the first node is "Dave Daverson"
            Node first = sll.Head;
            Assert.AreEqual(name, first.Value);

            //Assert that the count is 7
            ulong size = sll.Count;
            Assert.AreEqual(7, size);

            //Assert that there is a next for the first node
            Assert.IsNotNull(first.Next);
            

        }

        [Test]
        public void TestAppendingToEmptyList()
        {
            sll.AddLast("Joe Blow");

            //assert node is null
            Assert.IsNull(sll.Head.Next);
        }

        
        [Test]  
        public void TestAppendintToNonEmptyList()
        {
            sll.AddFirst("Joe Blow");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Sam Sammerson");

            string name = "Dave Daverson";

            sll.AddLast(name);

            Node foundNode = new Node();

            for(Node node = sll.Head; node!= null; node = node.Next)
            {
                foundNode= node;
            }

            //assert if the last value is the right value
            Assert.AreEqual("Dave Daverson", foundNode.Value);

            //Assert if the next of the last node is null
            Assert.IsNull(foundNode.Next);
        }

        [Test]  
        public void TestRemovingFirstFromList()
        {
            sll.AddFirst("Joe Blow");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Sam Sammerson");
            sll.AddFirst("Dave Daverson");

            sll.RemoveFirst();

            //check if the first value is removed
            Assert.AreNotEqual("Dave Daverson", sll.Head.Value);

            //assert if the count decreased by one after removing the first
            Assert.AreEqual(6, sll.Count);
        }

        [Test]  
        public void TestRemovingLastFromList()
        {
            sll.AddFirst("Joe Blow");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Sam Sammerson");
            sll.AddFirst("Dave Daverson");

            sll.RemoveLast();

            Node lastNode = new Node();
            for (Node node = sll.Head; node != null; node = node.Next)
            {
                lastNode = node;
            }

            //Assert that the count is 6
            Assert.AreEqual(6, sll.Count);

            //Assert that the last value is Joe Schmoe after removing Joe Blow
            Assert.AreEqual("Joe Schmoe", lastNode.Value);


        }

        [Test]  
        public void TestGetValueFromList()
        {
            sll.AddFirst("Joe Blow");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Jane Doe");
            sll.AddFirst("Bob Bobberson");
            sll.AddFirst("Sam Sammerson");
            sll.AddFirst("Dave Daverson");

            string value1 = sll.GetValue(3);
            string value2 = sll.GetValue(6);

            //Assert the value at given index are equal
            Assert.AreEqual("Jane Doe", value1);
            Assert.AreEqual("Joe Blow", value2);
            
        }

        [TearDown]
        public void Teardown()
        {
            sll.Head = null;
            sll.Count= 0;       

        }
    }
}