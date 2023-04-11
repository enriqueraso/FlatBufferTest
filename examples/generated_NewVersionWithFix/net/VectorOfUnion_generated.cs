// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace OMTLS.FlatBuffers
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public enum OverallLikelyException4Union : byte
{
  NONE = 0,
  DetailedException2 = 1,
  DetailedException4 = 2,
};

public struct DetailedException3Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DetailedException3Vector GetRootAsDetailedException3Vector(ByteBuffer _bb) { return GetRootAsDetailedException3Vector(_bb, new DetailedException3Vector()); }
  public static DetailedException3Vector GetRootAsDetailedException3Vector(ByteBuffer _bb, DetailedException3Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailedException3Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OMTLS.FlatBuffers.OverallLikelyExceptionUnion AType(int j) { int o = __p.__offset(4); return o != 0 ? (OMTLS.FlatBuffers.OverallLikelyExceptionUnion)__p.bb.Get(__p.__vector(o) + j * 1) : (OMTLS.FlatBuffers.OverallLikelyExceptionUnion)0; }
  public int ATypeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<OMTLS.FlatBuffers.OverallLikelyExceptionUnion> GetATypeBytes() { return __p.__vector_as_span<OMTLS.FlatBuffers.OverallLikelyExceptionUnion>(4, 1); }
#else
  public ArraySegment<byte>? GetATypeBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public OMTLS.FlatBuffers.OverallLikelyExceptionUnion[] GetATypeArray() { int o = __p.__offset(4); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); OMTLS.FlatBuffers.OverallLikelyExceptionUnion[] a = new OMTLS.FlatBuffers.OverallLikelyExceptionUnion[l]; for (int i = 0; i < l; i++) { a[i] = (OMTLS.FlatBuffers.OverallLikelyExceptionUnion)__p.bb.Get(p + i * 1); } return a; }
  public TTable? A<TTable>(int j) where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(__p.__vector(o) + j * 4) : null; }
  public int ALength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<OMTLS.FlatBuffers.DetailedException3Vector> CreateDetailedException3Vector(FlatBufferBuilder builder,
      VectorOffset A_typeOffset = default(VectorOffset),
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartTable(2);
    DetailedException3Vector.AddA(builder, AOffset);
    DetailedException3Vector.AddAType(builder, A_typeOffset);
    return DetailedException3Vector.EndDetailedException3Vector(builder);
  }

  public static void StartDetailedException3Vector(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddAType(FlatBufferBuilder builder, VectorOffset aTypeOffset) { builder.AddOffset(0, aTypeOffset.Value, 0); }
  public static VectorOffset CreateATypeVector(FlatBufferBuilder builder, OMTLS.FlatBuffers.OverallLikelyExceptionUnion[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte((byte)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, OMTLS.FlatBuffers.OverallLikelyExceptionUnion[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, ArraySegment<OMTLS.FlatBuffers.OverallLikelyExceptionUnion> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<OMTLS.FlatBuffers.OverallLikelyExceptionUnion>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartATypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset aOffset) { builder.AddOffset(1, aOffset.Value, 0); }
  public static VectorOffset CreateAVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<OMTLS.FlatBuffers.DetailedException3Vector> EndDetailedException3Vector(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<OMTLS.FlatBuffers.DetailedException3Vector>(o);
  }
}

public struct DetailedException4 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DetailedException4 GetRootAsDetailedException4(ByteBuffer _bb) { return GetRootAsDetailedException4(_bb, new DetailedException4()); }
  public static DetailedException4 GetRootAsDetailedException4(ByteBuffer _bb, DetailedException4 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailedException4 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong _Code { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public string _Message { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> Get_MessageBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? Get_MessageBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] Get_MessageArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<OMTLS.FlatBuffers.DetailedException4> CreateDetailedException4(FlatBufferBuilder builder,
      ulong _code = 0,
      StringOffset _messageOffset = default(StringOffset)) {
    builder.StartTable(2);
    DetailedException4.Add_Code(builder, _code);
    DetailedException4.Add_Message(builder, _messageOffset);
    return DetailedException4.EndDetailedException4(builder);
  }

  public static void StartDetailedException4(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void Add_Code(FlatBufferBuilder builder, ulong _Code) { builder.AddUlong(0, _Code, 0); }
  public static void Add_Message(FlatBufferBuilder builder, StringOffset _MessageOffset) { builder.AddOffset(1, _MessageOffset.Value, 0); }
  public static Offset<OMTLS.FlatBuffers.DetailedException4> EndDetailedException4(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<OMTLS.FlatBuffers.DetailedException4>(o);
  }
}

public struct DetailedException4Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DetailedException4Vector GetRootAsDetailedException4Vector(ByteBuffer _bb) { return GetRootAsDetailedException4Vector(_bb, new DetailedException4Vector()); }
  public static DetailedException4Vector GetRootAsDetailedException4Vector(ByteBuffer _bb, DetailedException4Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailedException4Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OMTLS.FlatBuffers.OverallLikelyException4Union AType(int j) { int o = __p.__offset(4); return o != 0 ? (OMTLS.FlatBuffers.OverallLikelyException4Union)__p.bb.Get(__p.__vector(o) + j * 1) : (OMTLS.FlatBuffers.OverallLikelyException4Union)0; }
  public int ATypeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<OMTLS.FlatBuffers.OverallLikelyException4Union> GetATypeBytes() { return __p.__vector_as_span<OMTLS.FlatBuffers.OverallLikelyException4Union>(4, 1); }
#else
  public ArraySegment<byte>? GetATypeBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public OMTLS.FlatBuffers.OverallLikelyException4Union[] GetATypeArray() { int o = __p.__offset(4); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); OMTLS.FlatBuffers.OverallLikelyException4Union[] a = new OMTLS.FlatBuffers.OverallLikelyException4Union[l]; for (int i = 0; i < l; i++) { a[i] = (OMTLS.FlatBuffers.OverallLikelyException4Union)__p.bb.Get(p + i * 1); } return a; }
  public TTable? A<TTable>(int j) where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(__p.__vector(o) + j * 4) : null; }
  public int ALength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public OMTLS.FlatBuffers.DetailedException4? B(int j) { int o = __p.__offset(8); return o != 0 ? (OMTLS.FlatBuffers.DetailedException4?)(new OMTLS.FlatBuffers.DetailedException4()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int BLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<OMTLS.FlatBuffers.DetailedException4Vector> CreateDetailedException4Vector(FlatBufferBuilder builder,
      VectorOffset A_typeOffset = default(VectorOffset),
      VectorOffset AOffset = default(VectorOffset),
      VectorOffset BOffset = default(VectorOffset)) {
    builder.StartTable(3);
    DetailedException4Vector.AddB(builder, BOffset);
    DetailedException4Vector.AddA(builder, AOffset);
    DetailedException4Vector.AddAType(builder, A_typeOffset);
    return DetailedException4Vector.EndDetailedException4Vector(builder);
  }

  public static void StartDetailedException4Vector(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddAType(FlatBufferBuilder builder, VectorOffset aTypeOffset) { builder.AddOffset(0, aTypeOffset.Value, 0); }
  public static VectorOffset CreateATypeVector(FlatBufferBuilder builder, OMTLS.FlatBuffers.OverallLikelyException4Union[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte((byte)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, OMTLS.FlatBuffers.OverallLikelyException4Union[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, ArraySegment<OMTLS.FlatBuffers.OverallLikelyException4Union> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<OMTLS.FlatBuffers.OverallLikelyException4Union>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartATypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset aOffset) { builder.AddOffset(1, aOffset.Value, 0); }
  public static VectorOffset CreateAVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddB(FlatBufferBuilder builder, VectorOffset bOffset) { builder.AddOffset(2, bOffset.Value, 0); }
  public static VectorOffset CreateBVector(FlatBufferBuilder builder, Offset<OMTLS.FlatBuffers.DetailedException4>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBVectorBlock(FlatBufferBuilder builder, Offset<OMTLS.FlatBuffers.DetailedException4>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OMTLS.FlatBuffers.DetailedException4>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<OMTLS.FlatBuffers.DetailedException4>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<OMTLS.FlatBuffers.DetailedException4Vector> EndDetailedException4Vector(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<OMTLS.FlatBuffers.DetailedException4Vector>(o);
  }
}

public struct DetailedException1Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DetailedException1Vector GetRootAsDetailedException1Vector(ByteBuffer _bb) { return GetRootAsDetailedException1Vector(_bb, new DetailedException1Vector()); }
  public static DetailedException1Vector GetRootAsDetailedException1Vector(ByteBuffer _bb, DetailedException1Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailedException1Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OMTLS.FlatBuffers.DetailedException1? A(int j) { int o = __p.__offset(4); return o != 0 ? (OMTLS.FlatBuffers.DetailedException1?)(new OMTLS.FlatBuffers.DetailedException1()).__assign(__p.__vector(o) + j * 8, __p.bb) : null; }
  public int ALength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<OMTLS.FlatBuffers.DetailedException1Vector> CreateDetailedException1Vector(FlatBufferBuilder builder,
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartTable(1);
    DetailedException1Vector.AddA(builder, AOffset);
    return DetailedException1Vector.EndDetailedException1Vector(builder);
  }

  public static void StartDetailedException1Vector(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset aOffset) { builder.AddOffset(0, aOffset.Value, 0); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<OMTLS.FlatBuffers.DetailedException1Vector> EndDetailedException1Vector(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<OMTLS.FlatBuffers.DetailedException1Vector>(o);
  }
}

public struct DetailedException2Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DetailedException2Vector GetRootAsDetailedException2Vector(ByteBuffer _bb) { return GetRootAsDetailedException2Vector(_bb, new DetailedException2Vector()); }
  public static DetailedException2Vector GetRootAsDetailedException2Vector(ByteBuffer _bb, DetailedException2Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailedException2Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OMTLS.FlatBuffers.DetailedException2? A(int j) { int o = __p.__offset(4); return o != 0 ? (OMTLS.FlatBuffers.DetailedException2?)(new OMTLS.FlatBuffers.DetailedException2()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ALength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<OMTLS.FlatBuffers.DetailedException2Vector> CreateDetailedException2Vector(FlatBufferBuilder builder,
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartTable(1);
    DetailedException2Vector.AddA(builder, AOffset);
    return DetailedException2Vector.EndDetailedException2Vector(builder);
  }

  public static void StartDetailedException2Vector(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset aOffset) { builder.AddOffset(0, aOffset.Value, 0); }
  public static VectorOffset CreateAVector(FlatBufferBuilder builder, Offset<OMTLS.FlatBuffers.DetailedException2>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, Offset<OMTLS.FlatBuffers.DetailedException2>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OMTLS.FlatBuffers.DetailedException2>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<OMTLS.FlatBuffers.DetailedException2>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<OMTLS.FlatBuffers.DetailedException2Vector> EndDetailedException2Vector(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<OMTLS.FlatBuffers.DetailedException2Vector>(o);
  }
}


}
