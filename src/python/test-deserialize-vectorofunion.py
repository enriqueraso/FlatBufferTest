#https://flatbuffers.dev/flatbuffers_guide_use_python.html
#https://flatbuffers.dev/flatbuffers_guide_writing_schema.html
#https://stackoverflow.com/questions/53656165/accessing-a-flatbuffers-union-in-python

import DetailedException1
import DetailedException2
import DetailedException3Vector
import OverallLikelyExceptionUnion
import DetailedException4
import DetailedException4Vector

def deserializeFbs(fileName):
    bytes = open(fileName, 'rb').read()    
    buffer = bytearray(bytes)
    detailedException3Vector = DetailedException3Vector.DetailedException3Vector.GetRootAsDetailedException3Vector(buffer, 0)
    print("DetailedException3Vector contains", detailedException3Vector.ATypeLength(), "items")

    if detailedException3Vector.ATypeLength() != detailedException3Vector.ALength():
        raise ValueError("file is corrupt", fileName)

    for i in range(detailedException3Vector.ATypeLength()):

        itemType = detailedException3Vector.AType(i)
        print("Item of type ", itemType)

        if itemType == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException2:
            a = detailedException3Vector.A(i)
            detailedException2 = DetailedException2.DetailedException2()
            detailedException2.Init(a.Bytes, a.Pos)
            print(detailedException2._exceptionValue())

        elif itemType == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException1:
            a = detailedException3Vector.A(i)
            detailedException1 = DetailedException1.DetailedException1()
            detailedException1.Init(a.Bytes, a.Pos)
            print(detailedException1._exceptionValue())

        elif itemType == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.NONE:
            print("No content in enum.")

        else:
            print("Type not supported")

# def deserializeDetailedException4Vector(fileName):
#     bytes = open(fileName, 'rb').read()    
#     buffer = bytearray(bytes)
#     detailedException4Vector = DetailedException4Vector.DetailedException4Vector.GetRootAsDetailedException4Vector(buffer, 0)
#     print("DetailedException4Vector contains ", detailedException4Vector.BLength(), "`B` items")

#     for i in range(detailedException4Vector.BLength()):

#         b = detailedException4Vector.B(i)
#         detailedException4 = DetailedException4.DetailedException4()
#         detailedException4.Init(b.Bytes, b.Pos)
#         print(b.._exceptionValue())

#         elif itemType == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException1:
#             a = detailedException3Vector.A(i)
#             detailedException1 = DetailedException1.DetailedException1()
#             detailedException1.Init(a.Bytes, a.Pos)
#             print(detailedException1._exceptionValue())

#         elif itemType == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.NONE:
#             print("No content in enum.")

#         else:
#             print("Type not supported")

# deserialize a vector of union with only one type
deserializeFbs('F:\\temp-fbs\\test.fb.DetailedException3VectorOfOneType.VectorOfUnion')

# deserialize a vector of union with multiple types
#deserializeFbs('F:\\temp-fbs\\test.fb.DetailedException3VectorOfMultipleTypes.VectorOfUnion')

# deserialize a vector
#deserializeDetailedException4Vector('F:\\temp-fbs\\test.fb.DetailedException4Vector.VectorOfUnion')
