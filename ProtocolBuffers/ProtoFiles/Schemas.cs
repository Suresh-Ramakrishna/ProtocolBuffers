// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Schemas.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Schemas.proto</summary>
public static partial class SchemasReflection {

  #region Descriptor
  /// <summary>File descriptor for Schemas.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SchemasReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1TY2hlbWFzLnByb3RvGhlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvIpgC",
          "CgtTY2FsYXJUeXBlcxIRCglJbnRlZ2VyMzIYASABKAUSEgoKVUludGVnZXIz",
          "MhgCIAEoDRISCgpTSW50ZWdlcjMyGAMgASgREg8KB0ZpeGVkMzIYBCABKAcS",
          "EAoIU0ZpeGVkMzIYBSABKA8SEQoJSW50ZWdlcjY0GAYgASgDEhIKClVJbnRl",
          "Z2VyNjQYByABKAQSEgoKU0ludGVnZXI2NBgIIAEoEhIPCgdGaXhlZDY0GAkg",
          "ASgGEhAKCFNGaXhlZDY0GAogASgQEg4KBkRvdWJsZRgLIAEoARINCgVGbG9h",
          "dBgMIAEoAhIPCgdCb29lbGFuGA0gASgIEg4KBlN0cmluZxgOIAEoCRINCgVC",
          "eXRlcxgPIAEoDCKDAgoMQ29tcGxleFR5cGVzEhQKA1NleBgBIAEoDjIHLkdl",
          "bmRlchIeCghTdWJDbGFzcxgCIAEoCzIMLlNjYWxhclR5cGVzEg8KB051bWJl",
          "cnMYAyADKAUSJQoHRGV0YWlscxgEIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5B",
          "bnkSEwoJSW50ZWdlcjMyGAUgASgFSAASEwoJSW50ZWdlcjY0GAYgASgDSAAS",
          "JQoETWFwcxgHIAMoCzIXLkNvbXBsZXhUeXBlcy5NYXBzRW50cnkaKwoJTWFw",
          "c0VudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoCToCOAFCBwoFT25l",
          "b2YqHgoGR2VuZGVyEggKBE1hbGUQABIKCgZGZW1hbGUQAWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Gender), }, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ScalarTypes), global::ScalarTypes.Parser, new[]{ "Integer32", "UInteger32", "SInteger32", "Fixed32", "SFixed32", "Integer64", "UInteger64", "SInteger64", "Fixed64", "SFixed64", "Double", "Float", "Booelan", "String", "Bytes" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ComplexTypes), global::ComplexTypes.Parser, new[]{ "Sex", "SubClass", "Numbers", "Details", "Integer32", "Integer64", "Maps" }, new[]{ "Oneof" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Enums
public enum Gender {
  [pbr::OriginalName("Male")] Male = 0,
  [pbr::OriginalName("Female")] Female = 1,
}

#endregion

#region Messages
public sealed partial class ScalarTypes : pb::IMessage<ScalarTypes> {
  private static readonly pb::MessageParser<ScalarTypes> _parser = new pb::MessageParser<ScalarTypes>(() => new ScalarTypes());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ScalarTypes> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SchemasReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ScalarTypes() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ScalarTypes(ScalarTypes other) : this() {
    integer32_ = other.integer32_;
    uInteger32_ = other.uInteger32_;
    sInteger32_ = other.sInteger32_;
    fixed32_ = other.fixed32_;
    sFixed32_ = other.sFixed32_;
    integer64_ = other.integer64_;
    uInteger64_ = other.uInteger64_;
    sInteger64_ = other.sInteger64_;
    fixed64_ = other.fixed64_;
    sFixed64_ = other.sFixed64_;
    double_ = other.double_;
    float_ = other.float_;
    booelan_ = other.booelan_;
    string_ = other.string_;
    bytes_ = other.bytes_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ScalarTypes Clone() {
    return new ScalarTypes(this);
  }

  /// <summary>Field number for the "Integer32" field.</summary>
  public const int Integer32FieldNumber = 1;
  private int integer32_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Integer32 {
    get { return integer32_; }
    set {
      integer32_ = value;
    }
  }

  /// <summary>Field number for the "UInteger32" field.</summary>
  public const int UInteger32FieldNumber = 2;
  private uint uInteger32_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint UInteger32 {
    get { return uInteger32_; }
    set {
      uInteger32_ = value;
    }
  }

  /// <summary>Field number for the "SInteger32" field.</summary>
  public const int SInteger32FieldNumber = 3;
  private int sInteger32_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int SInteger32 {
    get { return sInteger32_; }
    set {
      sInteger32_ = value;
    }
  }

  /// <summary>Field number for the "Fixed32" field.</summary>
  public const int Fixed32FieldNumber = 4;
  private uint fixed32_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Fixed32 {
    get { return fixed32_; }
    set {
      fixed32_ = value;
    }
  }

  /// <summary>Field number for the "SFixed32" field.</summary>
  public const int SFixed32FieldNumber = 5;
  private int sFixed32_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int SFixed32 {
    get { return sFixed32_; }
    set {
      sFixed32_ = value;
    }
  }

  /// <summary>Field number for the "Integer64" field.</summary>
  public const int Integer64FieldNumber = 6;
  private long integer64_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Integer64 {
    get { return integer64_; }
    set {
      integer64_ = value;
    }
  }

  /// <summary>Field number for the "UInteger64" field.</summary>
  public const int UInteger64FieldNumber = 7;
  private ulong uInteger64_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ulong UInteger64 {
    get { return uInteger64_; }
    set {
      uInteger64_ = value;
    }
  }

  /// <summary>Field number for the "SInteger64" field.</summary>
  public const int SInteger64FieldNumber = 8;
  private long sInteger64_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long SInteger64 {
    get { return sInteger64_; }
    set {
      sInteger64_ = value;
    }
  }

  /// <summary>Field number for the "Fixed64" field.</summary>
  public const int Fixed64FieldNumber = 9;
  private ulong fixed64_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ulong Fixed64 {
    get { return fixed64_; }
    set {
      fixed64_ = value;
    }
  }

  /// <summary>Field number for the "SFixed64" field.</summary>
  public const int SFixed64FieldNumber = 10;
  private long sFixed64_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long SFixed64 {
    get { return sFixed64_; }
    set {
      sFixed64_ = value;
    }
  }

  /// <summary>Field number for the "Double" field.</summary>
  public const int DoubleFieldNumber = 11;
  private double double_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Double {
    get { return double_; }
    set {
      double_ = value;
    }
  }

  /// <summary>Field number for the "Float" field.</summary>
  public const int FloatFieldNumber = 12;
  private float float_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Float {
    get { return float_; }
    set {
      float_ = value;
    }
  }

  /// <summary>Field number for the "Booelan" field.</summary>
  public const int BooelanFieldNumber = 13;
  private bool booelan_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Booelan {
    get { return booelan_; }
    set {
      booelan_ = value;
    }
  }

  /// <summary>Field number for the "String" field.</summary>
  public const int StringFieldNumber = 14;
  private string string_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string String {
    get { return string_; }
    set {
      string_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Bytes" field.</summary>
  public const int BytesFieldNumber = 15;
  private pb::ByteString bytes_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Bytes {
    get { return bytes_; }
    set {
      bytes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ScalarTypes);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ScalarTypes other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Integer32 != other.Integer32) return false;
    if (UInteger32 != other.UInteger32) return false;
    if (SInteger32 != other.SInteger32) return false;
    if (Fixed32 != other.Fixed32) return false;
    if (SFixed32 != other.SFixed32) return false;
    if (Integer64 != other.Integer64) return false;
    if (UInteger64 != other.UInteger64) return false;
    if (SInteger64 != other.SInteger64) return false;
    if (Fixed64 != other.Fixed64) return false;
    if (SFixed64 != other.SFixed64) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Double, other.Double)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Float, other.Float)) return false;
    if (Booelan != other.Booelan) return false;
    if (String != other.String) return false;
    if (Bytes != other.Bytes) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Integer32 != 0) hash ^= Integer32.GetHashCode();
    if (UInteger32 != 0) hash ^= UInteger32.GetHashCode();
    if (SInteger32 != 0) hash ^= SInteger32.GetHashCode();
    if (Fixed32 != 0) hash ^= Fixed32.GetHashCode();
    if (SFixed32 != 0) hash ^= SFixed32.GetHashCode();
    if (Integer64 != 0L) hash ^= Integer64.GetHashCode();
    if (UInteger64 != 0UL) hash ^= UInteger64.GetHashCode();
    if (SInteger64 != 0L) hash ^= SInteger64.GetHashCode();
    if (Fixed64 != 0UL) hash ^= Fixed64.GetHashCode();
    if (SFixed64 != 0L) hash ^= SFixed64.GetHashCode();
    if (Double != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Double);
    if (Float != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Float);
    if (Booelan != false) hash ^= Booelan.GetHashCode();
    if (String.Length != 0) hash ^= String.GetHashCode();
    if (Bytes.Length != 0) hash ^= Bytes.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Integer32 != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Integer32);
    }
    if (UInteger32 != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(UInteger32);
    }
    if (SInteger32 != 0) {
      output.WriteRawTag(24);
      output.WriteSInt32(SInteger32);
    }
    if (Fixed32 != 0) {
      output.WriteRawTag(37);
      output.WriteFixed32(Fixed32);
    }
    if (SFixed32 != 0) {
      output.WriteRawTag(45);
      output.WriteSFixed32(SFixed32);
    }
    if (Integer64 != 0L) {
      output.WriteRawTag(48);
      output.WriteInt64(Integer64);
    }
    if (UInteger64 != 0UL) {
      output.WriteRawTag(56);
      output.WriteUInt64(UInteger64);
    }
    if (SInteger64 != 0L) {
      output.WriteRawTag(64);
      output.WriteSInt64(SInteger64);
    }
    if (Fixed64 != 0UL) {
      output.WriteRawTag(73);
      output.WriteFixed64(Fixed64);
    }
    if (SFixed64 != 0L) {
      output.WriteRawTag(81);
      output.WriteSFixed64(SFixed64);
    }
    if (Double != 0D) {
      output.WriteRawTag(89);
      output.WriteDouble(Double);
    }
    if (Float != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(Float);
    }
    if (Booelan != false) {
      output.WriteRawTag(104);
      output.WriteBool(Booelan);
    }
    if (String.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(String);
    }
    if (Bytes.Length != 0) {
      output.WriteRawTag(122);
      output.WriteBytes(Bytes);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Integer32 != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Integer32);
    }
    if (UInteger32 != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UInteger32);
    }
    if (SInteger32 != 0) {
      size += 1 + pb::CodedOutputStream.ComputeSInt32Size(SInteger32);
    }
    if (Fixed32 != 0) {
      size += 1 + 4;
    }
    if (SFixed32 != 0) {
      size += 1 + 4;
    }
    if (Integer64 != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Integer64);
    }
    if (UInteger64 != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UInteger64);
    }
    if (SInteger64 != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeSInt64Size(SInteger64);
    }
    if (Fixed64 != 0UL) {
      size += 1 + 8;
    }
    if (SFixed64 != 0L) {
      size += 1 + 8;
    }
    if (Double != 0D) {
      size += 1 + 8;
    }
    if (Float != 0F) {
      size += 1 + 4;
    }
    if (Booelan != false) {
      size += 1 + 1;
    }
    if (String.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(String);
    }
    if (Bytes.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Bytes);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ScalarTypes other) {
    if (other == null) {
      return;
    }
    if (other.Integer32 != 0) {
      Integer32 = other.Integer32;
    }
    if (other.UInteger32 != 0) {
      UInteger32 = other.UInteger32;
    }
    if (other.SInteger32 != 0) {
      SInteger32 = other.SInteger32;
    }
    if (other.Fixed32 != 0) {
      Fixed32 = other.Fixed32;
    }
    if (other.SFixed32 != 0) {
      SFixed32 = other.SFixed32;
    }
    if (other.Integer64 != 0L) {
      Integer64 = other.Integer64;
    }
    if (other.UInteger64 != 0UL) {
      UInteger64 = other.UInteger64;
    }
    if (other.SInteger64 != 0L) {
      SInteger64 = other.SInteger64;
    }
    if (other.Fixed64 != 0UL) {
      Fixed64 = other.Fixed64;
    }
    if (other.SFixed64 != 0L) {
      SFixed64 = other.SFixed64;
    }
    if (other.Double != 0D) {
      Double = other.Double;
    }
    if (other.Float != 0F) {
      Float = other.Float;
    }
    if (other.Booelan != false) {
      Booelan = other.Booelan;
    }
    if (other.String.Length != 0) {
      String = other.String;
    }
    if (other.Bytes.Length != 0) {
      Bytes = other.Bytes;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Integer32 = input.ReadInt32();
          break;
        }
        case 16: {
          UInteger32 = input.ReadUInt32();
          break;
        }
        case 24: {
          SInteger32 = input.ReadSInt32();
          break;
        }
        case 37: {
          Fixed32 = input.ReadFixed32();
          break;
        }
        case 45: {
          SFixed32 = input.ReadSFixed32();
          break;
        }
        case 48: {
          Integer64 = input.ReadInt64();
          break;
        }
        case 56: {
          UInteger64 = input.ReadUInt64();
          break;
        }
        case 64: {
          SInteger64 = input.ReadSInt64();
          break;
        }
        case 73: {
          Fixed64 = input.ReadFixed64();
          break;
        }
        case 81: {
          SFixed64 = input.ReadSFixed64();
          break;
        }
        case 89: {
          Double = input.ReadDouble();
          break;
        }
        case 101: {
          Float = input.ReadFloat();
          break;
        }
        case 104: {
          Booelan = input.ReadBool();
          break;
        }
        case 114: {
          String = input.ReadString();
          break;
        }
        case 122: {
          Bytes = input.ReadBytes();
          break;
        }
      }
    }
  }

}

public sealed partial class ComplexTypes : pb::IMessage<ComplexTypes> {
  private static readonly pb::MessageParser<ComplexTypes> _parser = new pb::MessageParser<ComplexTypes>(() => new ComplexTypes());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ComplexTypes> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SchemasReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ComplexTypes() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ComplexTypes(ComplexTypes other) : this() {
    sex_ = other.sex_;
    subClass_ = other.subClass_ != null ? other.subClass_.Clone() : null;
    numbers_ = other.numbers_.Clone();
    details_ = other.details_ != null ? other.details_.Clone() : null;
    maps_ = other.maps_.Clone();
    switch (other.OneofCase) {
      case OneofOneofCase.Integer32:
        Integer32 = other.Integer32;
        break;
      case OneofOneofCase.Integer64:
        Integer64 = other.Integer64;
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ComplexTypes Clone() {
    return new ComplexTypes(this);
  }

  /// <summary>Field number for the "Sex" field.</summary>
  public const int SexFieldNumber = 1;
  private global::Gender sex_ = global::Gender.Male;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Gender Sex {
    get { return sex_; }
    set {
      sex_ = value;
    }
  }

  /// <summary>Field number for the "SubClass" field.</summary>
  public const int SubClassFieldNumber = 2;
  private global::ScalarTypes subClass_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ScalarTypes SubClass {
    get { return subClass_; }
    set {
      subClass_ = value;
    }
  }

  /// <summary>Field number for the "Numbers" field.</summary>
  public const int NumbersFieldNumber = 3;
  private static readonly pb::FieldCodec<int> _repeated_numbers_codec
      = pb::FieldCodec.ForInt32(26);
  private readonly pbc::RepeatedField<int> numbers_ = new pbc::RepeatedField<int>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<int> Numbers {
    get { return numbers_; }
  }

  /// <summary>Field number for the "Details" field.</summary>
  public const int DetailsFieldNumber = 4;
  private global::Google.Protobuf.WellKnownTypes.Any details_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Google.Protobuf.WellKnownTypes.Any Details {
    get { return details_; }
    set {
      details_ = value;
    }
  }

  /// <summary>Field number for the "Integer32" field.</summary>
  public const int Integer32FieldNumber = 5;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Integer32 {
    get { return oneofCase_ == OneofOneofCase.Integer32 ? (int) oneof_ : 0; }
    set {
      oneof_ = value;
      oneofCase_ = OneofOneofCase.Integer32;
    }
  }

  /// <summary>Field number for the "Integer64" field.</summary>
  public const int Integer64FieldNumber = 6;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Integer64 {
    get { return oneofCase_ == OneofOneofCase.Integer64 ? (long) oneof_ : 0L; }
    set {
      oneof_ = value;
      oneofCase_ = OneofOneofCase.Integer64;
    }
  }

  /// <summary>Field number for the "Maps" field.</summary>
  public const int MapsFieldNumber = 7;
  private static readonly pbc::MapField<int, string>.Codec _map_maps_codec
      = new pbc::MapField<int, string>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForString(18, ""), 58);
  private readonly pbc::MapField<int, string> maps_ = new pbc::MapField<int, string>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, string> Maps {
    get { return maps_; }
  }

  private object oneof_;
  /// <summary>Enum of possible cases for the "Oneof" oneof.</summary>
  public enum OneofOneofCase {
    None = 0,
    Integer32 = 5,
    Integer64 = 6,
  }
  private OneofOneofCase oneofCase_ = OneofOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public OneofOneofCase OneofCase {
    get { return oneofCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearOneof() {
    oneofCase_ = OneofOneofCase.None;
    oneof_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ComplexTypes);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ComplexTypes other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Sex != other.Sex) return false;
    if (!object.Equals(SubClass, other.SubClass)) return false;
    if(!numbers_.Equals(other.numbers_)) return false;
    if (!object.Equals(Details, other.Details)) return false;
    if (Integer32 != other.Integer32) return false;
    if (Integer64 != other.Integer64) return false;
    if (!Maps.Equals(other.Maps)) return false;
    if (OneofCase != other.OneofCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Sex != global::Gender.Male) hash ^= Sex.GetHashCode();
    if (subClass_ != null) hash ^= SubClass.GetHashCode();
    hash ^= numbers_.GetHashCode();
    if (details_ != null) hash ^= Details.GetHashCode();
    if (oneofCase_ == OneofOneofCase.Integer32) hash ^= Integer32.GetHashCode();
    if (oneofCase_ == OneofOneofCase.Integer64) hash ^= Integer64.GetHashCode();
    hash ^= Maps.GetHashCode();
    hash ^= (int) oneofCase_;
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Sex != global::Gender.Male) {
      output.WriteRawTag(8);
      output.WriteEnum((int) Sex);
    }
    if (subClass_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(SubClass);
    }
    numbers_.WriteTo(output, _repeated_numbers_codec);
    if (details_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Details);
    }
    if (oneofCase_ == OneofOneofCase.Integer32) {
      output.WriteRawTag(40);
      output.WriteInt32(Integer32);
    }
    if (oneofCase_ == OneofOneofCase.Integer64) {
      output.WriteRawTag(48);
      output.WriteInt64(Integer64);
    }
    maps_.WriteTo(output, _map_maps_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Sex != global::Gender.Male) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Sex);
    }
    if (subClass_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SubClass);
    }
    size += numbers_.CalculateSize(_repeated_numbers_codec);
    if (details_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Details);
    }
    if (oneofCase_ == OneofOneofCase.Integer32) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Integer32);
    }
    if (oneofCase_ == OneofOneofCase.Integer64) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Integer64);
    }
    size += maps_.CalculateSize(_map_maps_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ComplexTypes other) {
    if (other == null) {
      return;
    }
    if (other.Sex != global::Gender.Male) {
      Sex = other.Sex;
    }
    if (other.subClass_ != null) {
      if (subClass_ == null) {
        SubClass = new global::ScalarTypes();
      }
      SubClass.MergeFrom(other.SubClass);
    }
    numbers_.Add(other.numbers_);
    if (other.details_ != null) {
      if (details_ == null) {
        Details = new global::Google.Protobuf.WellKnownTypes.Any();
      }
      Details.MergeFrom(other.Details);
    }
    maps_.Add(other.maps_);
    switch (other.OneofCase) {
      case OneofOneofCase.Integer32:
        Integer32 = other.Integer32;
        break;
      case OneofOneofCase.Integer64:
        Integer64 = other.Integer64;
        break;
    }

    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Sex = (global::Gender) input.ReadEnum();
          break;
        }
        case 18: {
          if (subClass_ == null) {
            SubClass = new global::ScalarTypes();
          }
          input.ReadMessage(SubClass);
          break;
        }
        case 26:
        case 24: {
          numbers_.AddEntriesFrom(input, _repeated_numbers_codec);
          break;
        }
        case 34: {
          if (details_ == null) {
            Details = new global::Google.Protobuf.WellKnownTypes.Any();
          }
          input.ReadMessage(Details);
          break;
        }
        case 40: {
          Integer32 = input.ReadInt32();
          break;
        }
        case 48: {
          Integer64 = input.ReadInt64();
          break;
        }
        case 58: {
          maps_.AddEntriesFrom(input, _map_maps_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code