# automatically generated by the FlatBuffers compiler, do not modify

# namespace: FlatBuffers

import flatbuffers

class DetailedException2Vector(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsDetailedException2Vector(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DetailedException2Vector()
        x.Init(buf, n + offset)
        return x

    # DetailedException2Vector
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DetailedException2Vector
    def A(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .DetailedException2 import DetailedException2
            obj = DetailedException2()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # DetailedException2Vector
    def ALength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def DetailedException2VectorStart(builder): builder.StartObject(1)
def DetailedException2VectorAddA(builder, A): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(A), 0)
def DetailedException2VectorStartAVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def DetailedException2VectorEnd(builder): return builder.EndObject()
