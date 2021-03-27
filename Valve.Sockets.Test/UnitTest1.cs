using NUnit.Framework;

namespace Valve.Sockets.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Library.Initialize();
        }

        [Test]
        public void Test1()
        {
            NetworkingSockets sockets = new NetworkingSockets();
            uint pollGroup = sockets.CreatePollGroup();
            sockets.DestroyPollGroup(pollGroup);
        }

        [TearDown]
        public void TearDown()
        {
            Library.Deinitialize();
        }
    }
}