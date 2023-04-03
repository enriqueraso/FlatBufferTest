// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace OMTLS.FlatBuffers
{

using global::System;
using global::FlatBuffers;

public enum OverallLikelyExceptionUnion : byte
{
 NONE = 0,
 DetailedException1 = 1,
 DetailedException2 = 2,
};

public enum OverallLikelyException4Union : byte
{
 NONE = 0,
 DetailedException2 = 1,
 DetailedException4 = 2,
};

public struct DetailedException1 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException1 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong _exceptionValue { get { return __p.bb.GetUlong(__p.bb_pos + 0); } }

  public static Offset<DetailedException1> CreateDetailedException1(FlatBufferBuilder builder, ulong _exceptionValue) {
    builder.Prep(8, 8);
    builder.PutUlong(_exceptionValue);
    return new Offset<DetailedException1>(builder.Offset);
  }
};

public struct DetailedException2 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException2 GetRootAsDetailedException2(ByteBuffer _bb) { return GetRootAsDetailedException2(_bb, new DetailedException2()); }
  public static DetailedException2 GetRootAsDetailedException2(ByteBuffer _bb, DetailedException2 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string _exceptionValue { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> Get_exceptionValueBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? Get_exceptionValueBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] Get_exceptionValueArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<DetailedException2> CreateDetailedException2(FlatBufferBuilder builder,
      StringOffset _exceptionValueOffset = default(StringOffset)) {
    builder.StartObject(1);
    DetailedException2.Add_exceptionValue(builder, _exceptionValueOffset);
    return DetailedException2.EndDetailedException2(builder);
  }

  public static void StartDetailedException2(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void Add_exceptionValue(FlatBufferBuilder builder, StringOffset ExceptionValueOffset) { builder.AddOffset(0, ExceptionValueOffset.Value, 0); }
  public static Offset<DetailedException2> EndDetailedException2(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException2>(o);
  }
};

public struct DetailedException3 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException3 GetRootAsDetailedException3(ByteBuffer _bb) { return GetRootAsDetailedException3(_bb, new DetailedException3()); }
  public static DetailedException3 GetRootAsDetailedException3(ByteBuffer _bb, DetailedException3 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OverallLikelyExceptionUnion AType { get { int o = __p.__offset(4); return o != 0 ? (OverallLikelyExceptionUnion)__p.bb.Get(o + __p.bb_pos) : OverallLikelyExceptionUnion.NONE; } }
  public TTable? A<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }

  public static Offset<DetailedException3> CreateDetailedException3(FlatBufferBuilder builder,
      OverallLikelyExceptionUnion A_type = OverallLikelyExceptionUnion.NONE,
      int AOffset = 0) {
    builder.StartObject(2);
    DetailedException3.AddA(builder, AOffset);
    DetailedException3.AddAType(builder, A_type);
    return DetailedException3.EndDetailedException3(builder);
  }

  public static void StartDetailedException3(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAType(FlatBufferBuilder builder, OverallLikelyExceptionUnion AType) { builder.AddByte(0, (byte)AType, 0); }
  public static void AddA(FlatBufferBuilder builder, int AOffset) { builder.AddOffset(1, AOffset, 0); }
  public static Offset<DetailedException3> EndDetailedException3(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException3>(o);
  }
};

public struct DetailedException3Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException3Vector GetRootAsDetailedException3Vector(ByteBuffer _bb) { return GetRootAsDetailedException3Vector(_bb, new DetailedException3Vector()); }
  public static DetailedException3Vector GetRootAsDetailedException3Vector(ByteBuffer _bb, DetailedException3Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException3Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OverallLikelyExceptionUnion AType(int j) { int o = __p.__offset(4); return o != 0 ? (OverallLikelyExceptionUnion)__p.bb.Get(__p.__vector(o) + j * 1) : (OverallLikelyExceptionUnion)0; }
  public int ATypeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetATypeBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetATypeBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public OverallLikelyExceptionUnion[] GetATypeArray() { return __p.__vector_as_array<OverallLikelyExceptionUnion>(4); }
  public TTable? A<TTable>(int j) where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(__p.__vector(o) + j * 4 - __p.bb_pos) : null; }
  public int ALength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<DetailedException3Vector> CreateDetailedException3Vector(FlatBufferBuilder builder,
      VectorOffset A_typeOffset = default(VectorOffset),
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartObject(2);
    DetailedException3Vector.AddA(builder, AOffset);
    DetailedException3Vector.AddAType(builder, A_typeOffset);
    return DetailedException3Vector.EndDetailedException3Vector(builder);
  }

  public static void StartDetailedException3Vector(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAType(FlatBufferBuilder builder, VectorOffset ATypeOffset) { builder.AddOffset(0, ATypeOffset.Value, 0); }
  public static VectorOffset CreateATypeVector(FlatBufferBuilder builder, OverallLikelyExceptionUnion[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte((byte)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, OverallLikelyExceptionUnion[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartATypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset AOffset) { builder.AddOffset(1, AOffset.Value, 0); }
  public static VectorOffset CreateAVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<DetailedException3Vector> EndDetailedException3Vector(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException3Vector>(o);
  }
};

public struct DetailedException4 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException4 GetRootAsDetailedException4(ByteBuffer _bb) { return GetRootAsDetailedException4(_bb, new DetailedException4()); }
  public static DetailedException4 GetRootAsDetailedException4(ByteBuffer _bb, DetailedException4 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException4 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong _code { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public string _message { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> Get_messageBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? Get_messageBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] Get_messageArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<DetailedException4> CreateDetailedException4(FlatBufferBuilder builder,
      ulong _code = 0,
      StringOffset _messageOffset = default(StringOffset)) {
    builder.StartObject(2);
    DetailedException4.Add_code(builder, _code);
    DetailedException4.Add_message(builder, _messageOffset);
    return DetailedException4.EndDetailedException4(builder);
  }

  public static void StartDetailedException4(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void Add_code(FlatBufferBuilder builder, ulong Code) { builder.AddUlong(0, Code, 0); }
  public static void Add_message(FlatBufferBuilder builder, StringOffset MessageOffset) { builder.AddOffset(1, MessageOffset.Value, 0); }
  public static Offset<DetailedException4> EndDetailedException4(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException4>(o);
  }
};

public struct DetailedException4Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException4Vector GetRootAsDetailedException4Vector(ByteBuffer _bb) { return GetRootAsDetailedException4Vector(_bb, new DetailedException4Vector()); }
  public static DetailedException4Vector GetRootAsDetailedException4Vector(ByteBuffer _bb, DetailedException4Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException4Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public OverallLikelyException4Union AType(int j) { int o = __p.__offset(4); return o != 0 ? (OverallLikelyException4Union)__p.bb.Get(__p.__vector(o) + j * 1) : (OverallLikelyException4Union)0; }
  public int ATypeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetATypeBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetATypeBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public OverallLikelyException4Union[] GetATypeArray() { return __p.__vector_as_array<OverallLikelyException4Union>(4); }
  public TTable? A<TTable>(int j) where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(__p.__vector(o) + j * 4 - __p.bb_pos) : null; }
  public int ALength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<DetailedException4Vector> CreateDetailedException4Vector(FlatBufferBuilder builder,
      VectorOffset A_typeOffset = default(VectorOffset),
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartObject(2);
    DetailedException4Vector.AddA(builder, AOffset);
    DetailedException4Vector.AddAType(builder, A_typeOffset);
    return DetailedException4Vector.EndDetailedException4Vector(builder);
  }

  public static void StartDetailedException4Vector(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAType(FlatBufferBuilder builder, VectorOffset ATypeOffset) { builder.AddOffset(0, ATypeOffset.Value, 0); }
  public static VectorOffset CreateATypeVector(FlatBufferBuilder builder, OverallLikelyException4Union[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte((byte)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateATypeVectorBlock(FlatBufferBuilder builder, OverallLikelyException4Union[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartATypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset AOffset) { builder.AddOffset(1, AOffset.Value, 0); }
  public static VectorOffset CreateAVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<DetailedException4Vector> EndDetailedException4Vector(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException4Vector>(o);
  }
};

public struct DetailedException1Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException1Vector GetRootAsDetailedException1Vector(ByteBuffer _bb) { return GetRootAsDetailedException1Vector(_bb, new DetailedException1Vector()); }
  public static DetailedException1Vector GetRootAsDetailedException1Vector(ByteBuffer _bb, DetailedException1Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException1Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public DetailedException1? A(int j) { int o = __p.__offset(4); return o != 0 ? (DetailedException1?)(new DetailedException1()).__assign(__p.__vector(o) + j * 8, __p.bb) : null; }
  public int ALength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<DetailedException1Vector> CreateDetailedException1Vector(FlatBufferBuilder builder,
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartObject(1);
    DetailedException1Vector.AddA(builder, AOffset);
    return DetailedException1Vector.EndDetailedException1Vector(builder);
  }

  public static void StartDetailedException1Vector(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset AOffset) { builder.AddOffset(0, AOffset.Value, 0); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<DetailedException1Vector> EndDetailedException1Vector(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException1Vector>(o);
  }
};

public struct DetailedException2Vector : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DetailedException2Vector GetRootAsDetailedException2Vector(ByteBuffer _bb) { return GetRootAsDetailedException2Vector(_bb, new DetailedException2Vector()); }
  public static DetailedException2Vector GetRootAsDetailedException2Vector(ByteBuffer _bb, DetailedException2Vector obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DetailedException2Vector __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public DetailedException2? A(int j) { int o = __p.__offset(4); return o != 0 ? (DetailedException2?)(new DetailedException2()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ALength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<DetailedException2Vector> CreateDetailedException2Vector(FlatBufferBuilder builder,
      VectorOffset AOffset = default(VectorOffset)) {
    builder.StartObject(1);
    DetailedException2Vector.AddA(builder, AOffset);
    return DetailedException2Vector.EndDetailedException2Vector(builder);
  }

  public static void StartDetailedException2Vector(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddA(FlatBufferBuilder builder, VectorOffset AOffset) { builder.AddOffset(0, AOffset.Value, 0); }
  public static VectorOffset CreateAVector(FlatBufferBuilder builder, Offset<DetailedException2>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAVectorBlock(FlatBufferBuilder builder, Offset<DetailedException2>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<DetailedException2Vector> EndDetailedException2Vector(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DetailedException2Vector>(o);
  }
};


}
