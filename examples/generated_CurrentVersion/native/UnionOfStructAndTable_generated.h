// automatically generated by the FlatBuffers compiler, do not modify


#ifndef FLATBUFFERS_GENERATED_UNIONOFSTRUCTANDTABLE_OMTLS_FLATBUFFERS_H_
#define FLATBUFFERS_GENERATED_UNIONOFSTRUCTANDTABLE_OMTLS_FLATBUFFERS_H_

#include "flatbuffers/flatbuffers.h"

namespace OMTLS {
namespace FlatBuffers {

struct DetailedException1;

struct DetailedException2;

struct DetailedException3;

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
  static const char * const names[] = {
    "NONE",
    "DetailedException1",
    "DetailedException2",
    nullptr
  };
  return names;
}

inline const char *EnumNameOverallLikelyExceptionUnion(OverallLikelyExceptionUnion e) {
  if (e < OverallLikelyExceptionUnion::NONE || e > OverallLikelyExceptionUnion::DetailedException2) return "";
  const size_t index = static_cast<size_t>(e);
  return EnumNamesOverallLikelyExceptionUnion()[index];
}

template<typename T> struct OverallLikelyExceptionUnionTraits {
  static const OverallLikelyExceptionUnion enum_value = OverallLikelyExceptionUnion::NONE;
};

template<> struct OverallLikelyExceptionUnionTraits<DetailedException1> {
  static const OverallLikelyExceptionUnion enum_value = OverallLikelyExceptionUnion::DetailedException1;
};

template<> struct OverallLikelyExceptionUnionTraits<DetailedException2> {
  static const OverallLikelyExceptionUnion enum_value = OverallLikelyExceptionUnion::DetailedException2;
};

bool VerifyOverallLikelyExceptionUnion(flatbuffers::Verifier &verifier, const void *obj, OverallLikelyExceptionUnion type);
bool VerifyOverallLikelyExceptionUnionVector(flatbuffers::Verifier &verifier, const flatbuffers::Vector<flatbuffers::Offset<void>> *values, const flatbuffers::Vector<uint8_t> *types);

FLATBUFFERS_MANUALLY_ALIGNED_STRUCT(8) DetailedException1 FLATBUFFERS_FINAL_CLASS {
 private:
  uint64_t _exceptionValue_;

 public:
  DetailedException1() {
    memset(static_cast<void *>(this), 0, sizeof(DetailedException1));
  }
  DetailedException1(uint64_t __exceptionValue)
      : _exceptionValue_(flatbuffers::EndianScalar(__exceptionValue)) {
  }
  uint64_t _exceptionValue() const {
    return flatbuffers::EndianScalar(_exceptionValue_);
  }
};
FLATBUFFERS_STRUCT_END(DetailedException1, 8);

struct DetailedException2 FLATBUFFERS_FINAL_CLASS : private flatbuffers::Table {
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT__EXCEPTIONVALUE = 4
  };
  const flatbuffers::String *_exceptionValue() const {
    return GetPointer<const flatbuffers::String *>(VT__EXCEPTIONVALUE);
  }
  bool Verify(flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT__EXCEPTIONVALUE) &&
           verifier.VerifyString(_exceptionValue()) &&
           verifier.EndTable();
  }
};

struct DetailedException2Builder {
  flatbuffers::FlatBufferBuilder &fbb_;
  flatbuffers::uoffset_t start_;
  void add__exceptionValue(flatbuffers::Offset<flatbuffers::String> _exceptionValue) {
    fbb_.AddOffset(DetailedException2::VT__EXCEPTIONVALUE, _exceptionValue);
  }
  explicit DetailedException2Builder(flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  DetailedException2Builder &operator=(const DetailedException2Builder &);
  flatbuffers::Offset<DetailedException2> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = flatbuffers::Offset<DetailedException2>(end);
    return o;
  }
};

inline flatbuffers::Offset<DetailedException2> CreateDetailedException2(
    flatbuffers::FlatBufferBuilder &_fbb,
    flatbuffers::Offset<flatbuffers::String> _exceptionValue = 0) {
  DetailedException2Builder builder_(_fbb);
  builder_.add__exceptionValue(_exceptionValue);
  return builder_.Finish();
}

inline flatbuffers::Offset<DetailedException2> CreateDetailedException2Direct(
    flatbuffers::FlatBufferBuilder &_fbb,
    const char *_exceptionValue = nullptr) {
  auto _exceptionValue__ = _exceptionValue ? _fbb.CreateString(_exceptionValue) : 0;
  return OMTLS::FlatBuffers::CreateDetailedException2(
      _fbb,
      _exceptionValue__);
}

struct DetailedException3 FLATBUFFERS_FINAL_CLASS : private flatbuffers::Table {
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_A_TYPE = 4,
    VT_A = 6
  };
  OverallLikelyExceptionUnion A_type() const {
    return static_cast<OverallLikelyExceptionUnion>(GetField<uint8_t>(VT_A_TYPE, 0));
  }
  const void *A() const {
    return GetPointer<const void *>(VT_A);
  }
  template<typename T> const T *A_as() const;
  const DetailedException1 *A_as_DetailedException1() const {
    return A_type() == OverallLikelyExceptionUnion::DetailedException1 ? static_cast<const DetailedException1 *>(A()) : nullptr;
  }
  const DetailedException2 *A_as_DetailedException2() const {
    return A_type() == OverallLikelyExceptionUnion::DetailedException2 ? static_cast<const DetailedException2 *>(A()) : nullptr;
  }
  bool Verify(flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyField<uint8_t>(verifier, VT_A_TYPE) &&
           VerifyOffset(verifier, VT_A) &&
           VerifyOverallLikelyExceptionUnion(verifier, A(), A_type()) &&
           verifier.EndTable();
  }
};

template<> inline const DetailedException1 *DetailedException3::A_as<DetailedException1>() const {
  return A_as_DetailedException1();
}

template<> inline const DetailedException2 *DetailedException3::A_as<DetailedException2>() const {
  return A_as_DetailedException2();
}

struct DetailedException3Builder {
  flatbuffers::FlatBufferBuilder &fbb_;
  flatbuffers::uoffset_t start_;
  void add_A_type(OverallLikelyExceptionUnion A_type) {
    fbb_.AddElement<uint8_t>(DetailedException3::VT_A_TYPE, static_cast<uint8_t>(A_type), 0);
  }
  void add_A(flatbuffers::Offset<void> A) {
    fbb_.AddOffset(DetailedException3::VT_A, A);
  }
  explicit DetailedException3Builder(flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  DetailedException3Builder &operator=(const DetailedException3Builder &);
  flatbuffers::Offset<DetailedException3> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = flatbuffers::Offset<DetailedException3>(end);
    return o;
  }
};

inline flatbuffers::Offset<DetailedException3> CreateDetailedException3(
    flatbuffers::FlatBufferBuilder &_fbb,
    OverallLikelyExceptionUnion A_type = OverallLikelyExceptionUnion::NONE,
    flatbuffers::Offset<void> A = 0) {
  DetailedException3Builder builder_(_fbb);
  builder_.add_A(A);
  builder_.add_A_type(A_type);
  return builder_.Finish();
}

inline bool VerifyOverallLikelyExceptionUnion(flatbuffers::Verifier &verifier, const void *obj, OverallLikelyExceptionUnion type) {
  switch (type) {
    case OverallLikelyExceptionUnion::NONE: {
      return true;
    }
    case OverallLikelyExceptionUnion::DetailedException1: {
      return verifier.Verify<DetailedException1>(static_cast<const uint8_t *>(obj), 0);
    }
    case OverallLikelyExceptionUnion::DetailedException2: {
      auto ptr = reinterpret_cast<const DetailedException2 *>(obj);
      return verifier.VerifyTable(ptr);
    }
    default: return false;
  }
}

inline bool VerifyOverallLikelyExceptionUnionVector(flatbuffers::Verifier &verifier, const flatbuffers::Vector<flatbuffers::Offset<void>> *values, const flatbuffers::Vector<uint8_t> *types) {
  if (!values || !types) return !values && !types;
  if (values->size() != types->size()) return false;
  for (flatbuffers::uoffset_t i = 0; i < values->size(); ++i) {
    if (!VerifyOverallLikelyExceptionUnion(
        verifier,  values->Get(i), types->GetEnum<OverallLikelyExceptionUnion>(i))) {
      return false;
    }
  }
  return true;
}

}  // namespace FlatBuffers
}  // namespace OMTLS

#endif  // FLATBUFFERS_GENERATED_UNIONOFSTRUCTANDTABLE_OMTLS_FLATBUFFERS_H_
