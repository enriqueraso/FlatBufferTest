#https://flatbuffers.dev/flatbuffers_guide_use_python.html
#https://flatbuffers.dev/flatbuffers_guide_writing_schema.html
#https://stackoverflow.com/questions/53656165/accessing-a-flatbuffers-union-in-python

import DetailedException1
import DetailedException2
import DetailedException3
import OverallLikelyExceptionUnion

def deserializeFbs(fileName):
    bytes = open(fileName, 'rb').read()    
    buffer = bytearray(bytes)
    detailedException3 = DetailedException3.DetailedException3.GetRootAsDetailedException3(buffer, 0)
    print("DetailedException3 contains type", detailedException3.AType())

    if detailedException3.AType() == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException2:
        a = detailedException3.A()
        detailedException2 = DetailedException2.DetailedException2()
        detailedException2.Init(a.Bytes, a.Pos)
        print(detailedException2._exceptionValue())

    elif detailedException3.AType() == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException1:
        a = detailedException3.A()
        detailedException1 = DetailedException1.DetailedException1()
        detailedException1.Init(a.Bytes, a.Pos)
        print(detailedException1._exceptionValue())

    elif detailedException3.AType() == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.NONE:
        print("No content in enum.")

    else:
        print("Type not supported")


# deserialize a union with a table
deserializeFbs('F:\\temp-fbs\\test.fb.DetailedException2.union')

# deserialize a union with a struct
deserializeFbs('F:\\temp-fbs\\test.fb.DetailedException1.union')
