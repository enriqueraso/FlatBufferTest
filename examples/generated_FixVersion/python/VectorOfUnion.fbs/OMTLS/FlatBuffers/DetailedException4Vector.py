# automatically generated by the FlatBuffers compiler, do not modify

# namespace: FlatBuffers

import flatbuffers

class DetailedException4Vector(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsDetailedException4Vector(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DetailedException4Vector()
        x.Init(buf, n + offset)
        return x

    # DetailedException4Vector
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DetailedException4Vector
    def AType(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint8Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 1))
        return 0

    # DetailedException4Vector
    def ATypeAsNumpy(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.GetVectorAsNumpy(flatbuffers.number_types.Uint8Flags, o)
        return 0

    # DetailedException4Vector
    def ATypeLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # DetailedException4Vector
    def A(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Union(a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # DetailedException4Vector
    def ALength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # DetailedException4Vector
    def B(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .DetailedException4 import DetailedException4
            obj = DetailedException4()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # DetailedException4Vector
    def BLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def DetailedException4VectorStart(builder): builder.StartObject(3)
def DetailedException4VectorAddAType(builder, AType): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AType), 0)
def DetailedException4VectorStartATypeVector(builder, numElems): return builder.StartVector(1, numElems, 1)
def DetailedException4VectorAddA(builder, A): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(A), 0)
def DetailedException4VectorStartAVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def DetailedException4VectorAddB(builder, B): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(B), 0)
def DetailedException4VectorStartBVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def DetailedException4VectorEnd(builder): return builder.EndObject()
