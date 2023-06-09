// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace OMTLS.FlatBuffers
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DetailedException1 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p = new Struct(_i, _bb); }
  public DetailedException1 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong _ExceptionValue { get { return __p.bb.GetUlong(__p.bb_pos + 0); } }

  public static Offset<OMTLS.FlatBuffers.DetailedException1> CreateDetailedException1(FlatBufferBuilder builder, ulong _ExceptionValue) {
    builder.Prep(8, 8);
    builder.PutUlong(_ExceptionValue);
    return new Offset<OMTLS.FlatBuffers.DetailedException1>(builder.Offset);
  }
}

public struct DetailedException2 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static DetailedException2 GetRootAsDetailedException2(ByteBuffer _bb) { return GetRootAsDetailedException2(_bb, new DetailedException2()); }
  public static DetailedException2 GetRootAsDetailedException2(ByteBuffer _bb, DetailedException2 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DetailedException2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string _ExceptionValue { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> Get_ExceptionValueBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? Get_ExceptionValueBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] Get_ExceptionValueArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<OMTLS.FlatBuffers.DetailedException2> CreateDetailedException2(FlatBufferBuilder builder,
      StringOffset _exceptionValueOffset = default(StringOffset)) {
    builder.StartTable(1);
    DetailedException2.Add_ExceptionValue(builder, _exceptionValueOffset);
    return DetailedException2.EndDetailedException2(builder);
  }

  public static void StartDetailedException2(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void Add_ExceptionValue(FlatBufferBuilder builder, StringOffset _ExceptionValueOffset) { builder.AddOffset(0, _ExceptionValueOffset.Value, 0); }
  public static Offset<OMTLS.FlatBuffers.DetailedException2> EndDetailedException2(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<OMTLS.FlatBuffers.DetailedException2>(o);
  }
}


}
