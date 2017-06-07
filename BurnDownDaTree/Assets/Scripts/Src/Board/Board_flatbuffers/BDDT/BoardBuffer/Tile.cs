// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace BDDT.BoardBuffer
{

using global::System;
using global::FlatBuffers;

public struct Tile : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Tile GetRootAsTile(ByteBuffer _bb) { return GetRootAsTile(_bb, new Tile()); }
  public static Tile GetRootAsTile(ByteBuffer _bb, Tile obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Tile __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public TileType Type { get { int o = __p.__offset(4); return o != 0 ? (TileType)__p.bb.GetSbyte(o + __p.bb_pos) : TileType.tree; } }
  public byte Crackiness { get { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)255; } }
  public byte Wetness { get { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<Tile> CreateTile(FlatBufferBuilder builder,
      TileType type = TileType.tree,
      byte crackiness = 255,
      byte wetness = 0) {
    builder.StartObject(3);
    Tile.AddWetness(builder, wetness);
    Tile.AddCrackiness(builder, crackiness);
    Tile.AddType(builder, type);
    return Tile.EndTile(builder);
  }

  public static void StartTile(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddType(FlatBufferBuilder builder, TileType type) { builder.AddSbyte(0, (sbyte)type, 0); }
  public static void AddCrackiness(FlatBufferBuilder builder, byte crackiness) { builder.AddByte(1, crackiness, 255); }
  public static void AddWetness(FlatBufferBuilder builder, byte wetness) { builder.AddByte(2, wetness, 0); }
  public static Offset<Tile> EndTile(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Tile>(o);
  }
};


}