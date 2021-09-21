using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SampleScenePlayModeTests
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SampleScenePlayModeTestsWithEnumeratorPasses()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(Application.isPlaying);
            yield return null;
        }
    }
}
