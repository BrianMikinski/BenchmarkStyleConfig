public struct BigByteArrayStruct
{
    public byte[] PileOfBytes;

    public BigByteArrayStruct()
    {
        PileOfBytes = new byte[40_000];
        //for (int i = 0; i < PileOfBytes.Length; i++)
        //{
        //    PileOfBytes[i] = 1;
        //}
    }
}
