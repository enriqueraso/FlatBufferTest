// automatically generated by the FlatBuffers compiler, do not modify


#ifndef FLATBUFFERS_GENERATED_VECTOROFUNION_OMTLS_FLATBUFFERS_H_
#define FLATBUFFERS_GENERATED_VECTOROFUNION_OMTLS_FLATBUFFERS_H_

#include "flatbuffers/flatbuffers.h"

// Ensure the included flatbuffers.h is the same version as when this file was
// generated, otherwise it may not be compatible.
static_assert(FLATBUFFERS_VERSION_MAJOR == 23 &&
              FLATBUFFERS_VERSION_MINOR == 3 &&
              FLATBUFFERS_VERSION_REVISION == 3,
             "Non-compatible flatbuffers version included");

namespace OMTLS {
namespace FlatBuffers {

struct DetailedException1;

struct DetailedException2;
struct DetailedException2Builder;

struct DetailedException3;
struct DetailedException3Builder;

struct DetailedException3Vector;
struct DetailedException3VectorBuilder;

struct DetailedException4;
struct DetailedException4Builder;

struct DetailedException4Vector;
struct DetailedException4VectorBuilder;

struct DetailedException1Vector;
struct DetailedException1VectorBuilder;

struct DetailedException2Vector;
struct DetailedException2VectorBuilder;

enum class OverallLikelyExceptionUnion : uint8_t {
  NONE = 0,
  DetailedException1 = 1,
  DetailedException2 = 2,
  MIN = NONE,
  MAX = DetailedException2
};

inline const OverallLikelyExceptionUnion (&EnumValuesOverallLikelyExceptionUnion())[3] {
  static const OverallLikelyExceptionUnion values[] = {
    OverallLikelyExceptionUnion::NONE,
    OverallLikelyExceptionUnion::DetailedException1,
    OverallLikelyExceptionUnion::DetailedException2
  };
  return values;
}

inline const char * const *EnumNamesOverallLikelyExceptionUnion() {
  static const char * const names[4] = {
    "NONE",
    "DetailedException1",
    "DetailedException2",
    nullptr
  };
  return names;
}

inline const char *EnumNameOverallLikelyExceptionUnion(OverallLikelyExceptionUnion e) {
  if (::flatbuffers::IsOutRange(e, OverallLikelyExceptionUnion::NONE, OverallLikelyExceptionUnion::DetailedException2)) return "";
  const size_t index = static_cast<size_t>(e);
  return EnumNamesOverallLikelyExceptionUnion()[index];
}

template<typename T> struct OverallLikelyExceptionUnionTraits {
  static const OverallLikelyExceptionUnion enum_value = OverallLikelyExceptionUnion::NONE;
};

template<> struct OverallLikelyExceptionUnionTraits<OMTLS::FlatBuffers::DetailedException1> {
  static const OverallLikelyExceptionUnion enum_value = OverallLikelyExceptionUnion::DetailedException1;
};

template<> struct OverallLikelyExceptionUnionTraits<OMTLS::FlatBuffers::DetailedException2> {
  static const OverallLikelyExceptionUnion enum_value = OverallLikelyExceptionUnion::DetailedException2;
};

bool VerifyOverallLikelyExceptionUnion(::flatbuffers::Verifier &verifier, const void *obj, OverallLikelyExceptionUnion type);
bool VerifyOverallLikelyExceptionUnionVector(::flatbuffers::Verifier &verifier, const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *values, const ::flatbuffers::Vector<OverallLikelyExceptionUnion> *types);

enum class OverallLikelyException4Union : uint8_t {
  NONE = 0,
  DetailedException2 = 1,
  DetailedException4 = 2,
  MIN = NONE,
  MAX = DetailedException4
};

inline const OverallLikelyException4Union (&EnumValuesOverallLikelyException4Union())[3] {
  static const OverallLikelyException4Union values[] = {
    OverallLikelyException4Union::NONE,
    OverallLikelyException4Union::DetailedException2,
    OverallLikelyException4Union::DetailedException4
  };
  return values;
}

inline const char * const *EnumNamesOverallLikelyException4Union() {
  static const char * const names[4] = {
    "NONE",
    "DetailedException2",
    "DetailedException4",
    nullptr
  };
  return names;
}

inline const char *EnumNameOverallLikelyException4Union(OverallLikelyException4Union e) {
  if (::flatbuffers::IsOutRange(e, OverallLikelyException4Union::NONE, OverallLikelyException4Union::DetailedException4)) return "";
  const size_t index = static_cast<size_t>(e);
  return EnumNamesOverallLikelyException4Union()[index];
}

template<typename T> struct OverallLikelyException4UnionTraits {
  static const OverallLikelyException4Union enum_value = OverallLikelyException4Union::NONE;
};

template<> struct OverallLikelyException4UnionTraits<OMTLS::FlatBuffers::DetailedException2> {
  static const OverallLikelyException4Union enum_value = OverallLikelyException4Union::DetailedException2;
};

template<> struct OverallLikelyException4UnionTraits<OMTLS::FlatBuffers::DetailedException4> {
  static const OverallLikelyException4Union enum_value = OverallLikelyException4Union::DetailedException4;
};

bool VerifyOverallLikelyException4Union(::flatbuffers::Verifier &verifier, const void *obj, OverallLikelyException4Union type);
bool VerifyOverallLikelyException4UnionVector(::flatbuffers::Verifier &verifier, const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *values, const ::flatbuffers::Vector<OverallLikelyException4Union> *types);

FLATBUFFERS_MANUALLY_ALIGNED_STRUCT(8) DetailedException1 FLATBUFFERS_FINAL_CLASS {
 private:
  uint64_t _exceptionValue_;

 public:
  DetailedException1()
      : _exceptionValue_(0) {
  }
  DetailedException1(uint64_t __exceptionValue)
      : _exceptionValue_(::flatbuffers::EndianScalar(__exceptionValue)) {
  }
  uint64_t _exceptionValue() const {
    return ::flatbuffers::EndianScalar(_exceptionValue_);
  }
};
FLATBUFFERS_STRUCT_END(DetailedException1, 8);

struct DetailedException2 FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException2Builder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT__EXCEPTIONVALUE = 4
  };
  const ::flatbuffers::String *_exceptionValue() const {
    return GetPointer<const ::flatbuffers::String *>(VT__EXCEPTIONVALUE);
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT__EXCEPTIONVALUE) &&
           verifier.VerifyString(_exceptionValue()) &&
           verifier.EndTable();
  }
};

struct DetailedException2Builder {
  typedef DetailedException2 Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add__exceptionValue(::flatbuffers::Offset<::flatbuffers::String> _exceptionValue) {
    fbb_.AddOffset(DetailedException2::VT__EXCEPTIONVALUE, _exceptionValue);
  }
  explicit DetailedException2Builder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException2> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException2>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException2> CreateDetailedException2(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    ::flatbuffers::Offset<::flatbuffers::String> _exceptionValue = 0) {
  DetailedException2Builder builder_(_fbb);
  builder_.add__exceptionValue(_exceptionValue);
  return builder_.Finish();
}

inline ::flatbuffers::Offset<DetailedException2> CreateDetailedException2Direct(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    const char *_exceptionValue = nullptr) {
  auto _exceptionValue__ = _exceptionValue ? _fbb.CreateString(_exceptionValue) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException2(
      _fbb,
      _exceptionValue__);
}

struct DetailedException3 FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException3Builder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_A_TYPE = 4,
    VT_A = 6
  };
  OMTLS::FlatBuffers::OverallLikelyExceptionUnion A_type() const {
    return static_cast<OMTLS::FlatBuffers::OverallLikelyExceptionUnion>(GetField<uint8_t>(VT_A_TYPE, 0));
  }
  const void *A() const {
    return GetPointer<const void *>(VT_A);
  }
  template<typename T> const T *A_as() const;
  const OMTLS::FlatBuffers::DetailedException1 *A_as_DetailedException1() const {
    return A_type() == OMTLS::FlatBuffers::OverallLikelyExceptionUnion::DetailedException1 ? static_cast<const OMTLS::FlatBuffers::DetailedException1 *>(A()) : nullptr;
  }
  const OMTLS::FlatBuffers::DetailedException2 *A_as_DetailedException2() const {
    return A_type() == OMTLS::FlatBuffers::OverallLikelyExceptionUnion::DetailedException2 ? static_cast<const OMTLS::FlatBuffers::DetailedException2 *>(A()) : nullptr;
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyField<uint8_t>(verifier, VT_A_TYPE, 1) &&
           VerifyOffset(verifier, VT_A) &&
           VerifyOverallLikelyExceptionUnion(verifier, A(), A_type()) &&
           verifier.EndTable();
  }
};

template<> inline const OMTLS::FlatBuffers::DetailedException1 *DetailedException3::A_as<OMTLS::FlatBuffers::DetailedException1>() const {
  return A_as_DetailedException1();
}

template<> inline const OMTLS::FlatBuffers::DetailedException2 *DetailedException3::A_as<OMTLS::FlatBuffers::DetailedException2>() const {
  return A_as_DetailedException2();
}

struct DetailedException3Builder {
  typedef DetailedException3 Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add_A_type(OMTLS::FlatBuffers::OverallLikelyExceptionUnion A_type) {
    fbb_.AddElement<uint8_t>(DetailedException3::VT_A_TYPE, static_cast<uint8_t>(A_type), 0);
  }
  void add_A(::flatbuffers::Offset<void> A) {
    fbb_.AddOffset(DetailedException3::VT_A, A);
  }
  explicit DetailedException3Builder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException3> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException3>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException3> CreateDetailedException3(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    OMTLS::FlatBuffers::OverallLikelyExceptionUnion A_type = OMTLS::FlatBuffers::OverallLikelyExceptionUnion::NONE,
    ::flatbuffers::Offset<void> A = 0) {
  DetailedException3Builder builder_(_fbb);
  builder_.add_A(A);
  builder_.add_A_type(A_type);
  return builder_.Finish();
}

struct DetailedException3Vector FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException3VectorBuilder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_A_TYPE = 4,
    VT_A = 6
  };
  const ::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyExceptionUnion> *A_type() const {
    return GetPointer<const ::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyExceptionUnion> *>(VT_A_TYPE);
  }
  const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *A() const {
    return GetPointer<const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *>(VT_A);
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT_A_TYPE) &&
           verifier.VerifyVector(A_type()) &&
           VerifyOffset(verifier, VT_A) &&
           verifier.VerifyVector(A()) &&
           VerifyOverallLikelyExceptionUnionVector(verifier, A(), A_type()) &&
           verifier.EndTable();
  }
};

struct DetailedException3VectorBuilder {
  typedef DetailedException3Vector Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add_A_type(::flatbuffers::Offset<::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyExceptionUnion>> A_type) {
    fbb_.AddOffset(DetailedException3Vector::VT_A_TYPE, A_type);
  }
  void add_A(::flatbuffers::Offset<::flatbuffers::Vector<::flatbuffers::Offset<void>>> A) {
    fbb_.AddOffset(DetailedException3Vector::VT_A, A);
  }
  explicit DetailedException3VectorBuilder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException3Vector> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException3Vector>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException3Vector> CreateDetailedException3Vector(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    ::flatbuffers::Offset<::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyExceptionUnion>> A_type = 0,
    ::flatbuffers::Offset<::flatbuffers::Vector<::flatbuffers::Offset<void>>> A = 0) {
  DetailedException3VectorBuilder builder_(_fbb);
  builder_.add_A(A);
  builder_.add_A_type(A_type);
  return builder_.Finish();
}

inline ::flatbuffers::Offset<DetailedException3Vector> CreateDetailedException3VectorDirect(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    const std::vector<OMTLS::FlatBuffers::OverallLikelyExceptionUnion> *A_type = nullptr,
    const std::vector<::flatbuffers::Offset<void>> *A = nullptr) {
  auto A_type__ = A_type ? _fbb.CreateVector<OMTLS::FlatBuffers::OverallLikelyExceptionUnion>(*A_type) : 0;
  auto A__ = A ? _fbb.CreateVector<::flatbuffers::Offset<void>>(*A) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException3Vector(
      _fbb,
      A_type__,
      A__);
}

struct DetailedException4 FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException4Builder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT__CODE = 4,
    VT__MESSAGE = 6
  };
  uint64_t _code() const {
    return GetField<uint64_t>(VT__CODE, 0);
  }
  const ::flatbuffers::String *_message() const {
    return GetPointer<const ::flatbuffers::String *>(VT__MESSAGE);
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyField<uint64_t>(verifier, VT__CODE, 8) &&
           VerifyOffset(verifier, VT__MESSAGE) &&
           verifier.VerifyString(_message()) &&
           verifier.EndTable();
  }
};

struct DetailedException4Builder {
  typedef DetailedException4 Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add__code(uint64_t _code) {
    fbb_.AddElement<uint64_t>(DetailedException4::VT__CODE, _code, 0);
  }
  void add__message(::flatbuffers::Offset<::flatbuffers::String> _message) {
    fbb_.AddOffset(DetailedException4::VT__MESSAGE, _message);
  }
  explicit DetailedException4Builder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException4> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException4>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException4> CreateDetailedException4(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    uint64_t _code = 0,
    ::flatbuffers::Offset<::flatbuffers::String> _message = 0) {
  DetailedException4Builder builder_(_fbb);
  builder_.add__code(_code);
  builder_.add__message(_message);
  return builder_.Finish();
}

inline ::flatbuffers::Offset<DetailedException4> CreateDetailedException4Direct(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    uint64_t _code = 0,
    const char *_message = nullptr) {
  auto _message__ = _message ? _fbb.CreateString(_message) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException4(
      _fbb,
      _code,
      _message__);
}

struct DetailedException4Vector FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException4VectorBuilder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_A_TYPE = 4,
    VT_A = 6
  };
  const ::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyException4Union> *A_type() const {
    return GetPointer<const ::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyException4Union> *>(VT_A_TYPE);
  }
  const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *A() const {
    return GetPointer<const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *>(VT_A);
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT_A_TYPE) &&
           verifier.VerifyVector(A_type()) &&
           VerifyOffset(verifier, VT_A) &&
           verifier.VerifyVector(A()) &&
           VerifyOverallLikelyException4UnionVector(verifier, A(), A_type()) &&
           verifier.EndTable();
  }
};

struct DetailedException4VectorBuilder {
  typedef DetailedException4Vector Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add_A_type(::flatbuffers::Offset<::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyException4Union>> A_type) {
    fbb_.AddOffset(DetailedException4Vector::VT_A_TYPE, A_type);
  }
  void add_A(::flatbuffers::Offset<::flatbuffers::Vector<::flatbuffers::Offset<void>>> A) {
    fbb_.AddOffset(DetailedException4Vector::VT_A, A);
  }
  explicit DetailedException4VectorBuilder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException4Vector> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException4Vector>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException4Vector> CreateDetailedException4Vector(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    ::flatbuffers::Offset<::flatbuffers::Vector<OMTLS::FlatBuffers::OverallLikelyException4Union>> A_type = 0,
    ::flatbuffers::Offset<::flatbuffers::Vector<::flatbuffers::Offset<void>>> A = 0) {
  DetailedException4VectorBuilder builder_(_fbb);
  builder_.add_A(A);
  builder_.add_A_type(A_type);
  return builder_.Finish();
}

inline ::flatbuffers::Offset<DetailedException4Vector> CreateDetailedException4VectorDirect(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    const std::vector<OMTLS::FlatBuffers::OverallLikelyException4Union> *A_type = nullptr,
    const std::vector<::flatbuffers::Offset<void>> *A = nullptr) {
  auto A_type__ = A_type ? _fbb.CreateVector<OMTLS::FlatBuffers::OverallLikelyException4Union>(*A_type) : 0;
  auto A__ = A ? _fbb.CreateVector<::flatbuffers::Offset<void>>(*A) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException4Vector(
      _fbb,
      A_type__,
      A__);
}

struct DetailedException1Vector FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException1VectorBuilder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_A = 4
  };
  const ::flatbuffers::Vector<const OMTLS::FlatBuffers::DetailedException1 *> *A() const {
    return GetPointer<const ::flatbuffers::Vector<const OMTLS::FlatBuffers::DetailedException1 *> *>(VT_A);
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT_A) &&
           verifier.VerifyVector(A()) &&
           verifier.EndTable();
  }
};

struct DetailedException1VectorBuilder {
  typedef DetailedException1Vector Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add_A(::flatbuffers::Offset<::flatbuffers::Vector<const OMTLS::FlatBuffers::DetailedException1 *>> A) {
    fbb_.AddOffset(DetailedException1Vector::VT_A, A);
  }
  explicit DetailedException1VectorBuilder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException1Vector> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException1Vector>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException1Vector> CreateDetailedException1Vector(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    ::flatbuffers::Offset<::flatbuffers::Vector<const OMTLS::FlatBuffers::DetailedException1 *>> A = 0) {
  DetailedException1VectorBuilder builder_(_fbb);
  builder_.add_A(A);
  return builder_.Finish();
}

inline ::flatbuffers::Offset<DetailedException1Vector> CreateDetailedException1VectorDirect(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    const std::vector<OMTLS::FlatBuffers::DetailedException1> *A = nullptr) {
  auto A__ = A ? _fbb.CreateVectorOfStructs<OMTLS::FlatBuffers::DetailedException1>(*A) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException1Vector(
      _fbb,
      A__);
}

struct DetailedException2Vector FLATBUFFERS_FINAL_CLASS : private ::flatbuffers::Table {
  typedef DetailedException2VectorBuilder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_A = 4
  };
  const ::flatbuffers::Vector<::flatbuffers::Offset<OMTLS::FlatBuffers::DetailedException2>> *A() const {
    return GetPointer<const ::flatbuffers::Vector<::flatbuffers::Offset<OMTLS::FlatBuffers::DetailedException2>> *>(VT_A);
  }
  bool Verify(::flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT_A) &&
           verifier.VerifyVector(A()) &&
           verifier.VerifyVectorOfTables(A()) &&
           verifier.EndTable();
  }
};

struct DetailedException2VectorBuilder {
  typedef DetailedException2Vector Table;
  ::flatbuffers::FlatBufferBuilder &fbb_;
  ::flatbuffers::uoffset_t start_;
  void add_A(::flatbuffers::Offset<::flatbuffers::Vector<::flatbuffers::Offset<OMTLS::FlatBuffers::DetailedException2>>> A) {
    fbb_.AddOffset(DetailedException2Vector::VT_A, A);
  }
  explicit DetailedException2VectorBuilder(::flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  ::flatbuffers::Offset<DetailedException2Vector> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = ::flatbuffers::Offset<DetailedException2Vector>(end);
    return o;
  }
};

inline ::flatbuffers::Offset<DetailedException2Vector> CreateDetailedException2Vector(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    ::flatbuffers::Offset<::flatbuffers::Vector<::flatbuffers::Offset<OMTLS::FlatBuffers::DetailedException2>>> A = 0) {
  DetailedException2VectorBuilder builder_(_fbb);
  builder_.add_A(A);
  return builder_.Finish();
}

inline ::flatbuffers::Offset<DetailedException2Vector> CreateDetailedException2VectorDirect(
    ::flatbuffers::FlatBufferBuilder &_fbb,
    const std::vector<::flatbuffers::Offset<OMTLS::FlatBuffers::DetailedException2>> *A = nullptr) {
  auto A__ = A ? _fbb.CreateVector<::flatbuffers::Offset<OMTLS::FlatBuffers::DetailedException2>>(*A) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException2Vector(
      _fbb,
      A__);
}

inline bool VerifyOverallLikelyExceptionUnion(::flatbuffers::Verifier &verifier, const void *obj, OverallLikelyExceptionUnion type) {
  switch (type) {
    case OverallLikelyExceptionUnion::NONE: {
      return true;
    }
    case OverallLikelyExceptionUnion::DetailedException1: {
      return verifier.VerifyField<OMTLS::FlatBuffers::DetailedException1>(static_cast<const uint8_t *>(obj), 0, 8);
    }
    case OverallLikelyExceptionUnion::DetailedException2: {
      auto ptr = reinterpret_cast<const OMTLS::FlatBuffers::DetailedException2 *>(obj);
      return verifier.VerifyTable(ptr);
    }
    default: return true;
  }
}

inline bool VerifyOverallLikelyExceptionUnionVector(::flatbuffers::Verifier &verifier, const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *values, const ::flatbuffers::Vector<OverallLikelyExceptionUnion> *types) {
  if (!values || !types) return !values && !types;
  if (values->size() != types->size()) return false;
  for (::flatbuffers::uoffset_t i = 0; i < values->size(); ++i) {
    if (!VerifyOverallLikelyExceptionUnion(
        verifier,  values->Get(i), types->GetEnum<OverallLikelyExceptionUnion>(i))) {
      return false;
    }
  }
  return true;
}

inline bool VerifyOverallLikelyException4Union(::flatbuffers::Verifier &verifier, const void *obj, OverallLikelyException4Union type) {
  switch (type) {
    case OverallLikelyException4Union::NONE: {
      return true;
    }
    case OverallLikelyException4Union::DetailedException2: {
      auto ptr = reinterpret_cast<const OMTLS::FlatBuffers::DetailedException2 *>(obj);
      return verifier.VerifyTable(ptr);
    }
    case OverallLikelyException4Union::DetailedException4: {
      auto ptr = reinterpret_cast<const OMTLS::FlatBuffers::DetailedException4 *>(obj);
      return verifier.VerifyTable(ptr);
    }
    default: return true;
  }
}

inline bool VerifyOverallLikelyException4UnionVector(::flatbuffers::Verifier &verifier, const ::flatbuffers::Vector<::flatbuffers::Offset<void>> *values, const ::flatbuffers::Vector<OverallLikelyException4Union> *types) {
  if (!values || !types) return !values && !types;
  if (values->size() != types->size()) return false;
  for (::flatbuffers::uoffset_t i = 0; i < values->size(); ++i) {
    if (!VerifyOverallLikelyException4Union(
        verifier,  values->Get(i), types->GetEnum<OverallLikelyException4Union>(i))) {
      return false;
    }
  }
  return true;
}

}  // namespace FlatBuffers
}  // namespace OMTLS

#endif  // FLATBUFFERS_GENERATED_VECTOROFUNION_OMTLS_FLATBUFFERS_H_
