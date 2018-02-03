using Bridge.Html5;
using Bridge.Test.NUnit;

namespace Bridge.ClientTest.Collections.Native
{
    /// <summary>
    /// This contains tests related to Bridge.Html5's supported TypedArray classes.
    /// </summary>
    [Category(Constants.MODULE_TYPEDARRAYS)]
    [TestFixture(TestNameFormat = "Constant Values - {0}")]
    public class TypedArray
    {
        /// <summary>
        /// For each supported TypedArray, check their constants.
        /// </summary>
        [Test]
        public void TestConstantValues()
        {
            #region Float32Array
            Assert.AreEqual(4, Float32Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 4.");
            Assert.AreEqual(3, Float32Array.length, "Length constant value is 3.");
            Assert.AreEqual("Float32Array", Float32Array.name, "Name constant value is 'Float32Array'.");
            #endregion Float32Array

            #region Float64Array
            Assert.AreEqual(8, Float64Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 8.");
            Assert.AreEqual(3, Float64Array.length, "Length constant value is 3.");
            Assert.AreEqual("Float64Array", Float64Array.name, "Name constant value is 'Float64Array'.");
            #endregion Float64Array

            #region Int16Array
            Assert.AreEqual(2, Int16Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 2.");
            Assert.AreEqual(3, Int16Array.length, "Length constant value is 3.");
            Assert.AreEqual("Int16Array", Int16Array.name, "Name constant value is 'Int16Array'.");
            #endregion Int16Array

            #region Int32Array
            Assert.AreEqual(4, Int32Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 4.");
            Assert.AreEqual(3, Int32Array.length, "Length constant value is 3.");
            Assert.AreEqual("Int32Array", Int32Array.name, "Name constant value is 'Int32Array'.");
            #endregion Int32Array

            #region Int8Array
            Assert.AreEqual(1, Int8Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 1.");
            Assert.AreEqual(3, Int8Array.length, "Length constant value is 3.");
            Assert.AreEqual("Int8Array", Int8Array.name, "Name constant value is 'Int8Array'.");
            #endregion Int8Array

            #region Uint16Array
            Assert.AreEqual(2, Uint16Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 2.");
            Assert.AreEqual(3, Uint16Array.length, "Length constant value is 3.");
            Assert.AreEqual("Uint16Array", Uint16Array.name, "Name constant value is 'Uint16Array'.");
            #endregion Uint16Array

            #region Uint32Array
            Assert.AreEqual(4, Uint32Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 4.");
            Assert.AreEqual(3, Uint32Array.length, "Length constant value is 3.");
            Assert.AreEqual("Uint32Array", Uint32Array.name, "Name constant value is 'Uint32Array'.");
            #endregion Uint32Array

            #region Uint8Array
            Assert.AreEqual(1, Uint8Array.BYTES_PER_ELEMENT, "Bytes per element constant value is 1.");
            Assert.AreEqual(3, Uint8Array.length, "Length constant value is 3.");
            Assert.AreEqual("Uint8Array", Uint8Array.name, "Name constant value is 'Uint8Array'.");
            #endregion Uint8Array

            #region Uint8ClampedArray
            Assert.AreEqual(1, Uint8ClampedArray.BYTES_PER_ELEMENT, "Bytes per element constant value is 1.");
            Assert.AreEqual(3, Uint8ClampedArray.length, "Length constant value is 3.");
            Assert.AreEqual("Uint8ClampedArray", Uint8ClampedArray.name, "Name constant value is 'Uint8ClampedArray'.");
            #endregion Uint8ClampedArray
        }
    }
}

/*
 * Tests generated by this script:
#!/bin/bash
_ifs="${IFS}"

IFS=$'\n' files=($(ls Html5/TypedArray/*Array.cs)) IFS="${_ifs}"

for file in "${files[@]}"; do
 clsnme="${file##* /}" # remove the whitespace here (would break C# comment block)
 clsnme="${clsnme%.*}"
 bpeval="$(egrep "element size\. [0-9]+" "${file}" | sed -E "s/^.* element size\. ([0 - 9]+) .*\$/\1/g")"
 lenval="$(egrep "Length property whose value is [0-9]+" "${file}" | sed -E "s/^.* Length property whose value is ([0 - 9]+)[^0-9]*.*\$/\1/g")"
 echo "
            #region ${clsnme}
            Assert.AreEqual(${bpeval}, ${clsnme}.BYTES_PER_ELEMENT, \"Bytes per element constant value is ${bpeval}.\");
            Assert.AreEqual(${lenval}, ${clsnme}.length, \"Length constant value is ${lenval}.\");
            Assert.AreEqual(\"${clsnme}\", ${clsnme}.name, \"Name constant value is '${clsnme}'.\");
            #endregion ${clsnme}"
done
 */