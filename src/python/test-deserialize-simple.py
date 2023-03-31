#https://flatbuffers.dev/flatbuffers_guide_use_python.html
#https://flatbuffers.dev/flatbuffers_guide_writing_schema.html
#https://stackoverflow.com/questions/53656165/accessing-a-flatbuffers-union-in-python

import DetailedException1
import DetailedException2

# desearialize a table
bytes = open('F:\\temp-fbs\\test.fb.DetailedException2.simple', 'rb').read()
buffer = bytearray(bytes)
detailedException2 = DetailedException2.DetailedException2.GetRootAsDetailedException2(buffer, 0)
value = detailedException2._exceptionValue()
print(value)

# deserialize a struct
bytes = open('F:\\temp-fbs\\test.fb.DetailedException1.simple', 'rb').read()
buffer = bytearray(bytes)
detailedException1 = DetailedException1.DetailedException1()
detailedException1.Init(buffer, 8)
value = detailedException1._exceptionValue()
print(value)