#e:\userdata\erasobar\appdata\roaming\python\python39\site-packages
#https://stackoverflow.com/questions/53656165/accessing-a-flatbuffers-union-in-python
import flatbuffers
import DetailedException1
import DetailedException2
import DetailedException3
import OverallLikelyExceptionUnion

bytes = open('F:\\temp-fbs\\test.fb.DetailedException2', 'rb').read()
#bytes = open('F:\\temp-fbs\\test.fb.DetailedException1', 'rb').read()
buffer = bytearray(bytes)
detailedException3 = DetailedException3.DetailedException3.GetRootAsDetailedException3(buffer, 0)

print("DetailedException3 contains type", detailedException3.AType())

if detailedException3.AType() == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException2:
    detailedException2 = DetailedException2.DetailedException2.GetRootAsDetailedException2(buffer, 0)
    print(detailedException2._exceptionValue())
elif detailedException3.AType() == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.DetailedException1:
    print(detailedException3.A()._exceptionValue())
elif detailedException3.AType() == OverallLikelyExceptionUnion.OverallLikelyExceptionUnion.NONE:
    print("No content in enum.")
else:
    print("Type not supported")
