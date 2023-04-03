# automatically generated by the FlatBuffers compiler, do not modify

# namespace: FlatBuffers

import flatbuffers
from flatbuffers.compat import import_numpy
np = import_numpy()

class OverallLikelyExceptionUnion(object):
    NONE = 0
    DetailedException1 = 1
    DetailedException2 = 2


class DetailedException1(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAs(cls, buf, offset=0):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DetailedException1()
        x.Init(buf, n + offset)
        return x

    @classmethod
    def GetRootAsDetailedException1(cls, buf, offset=0):
        """This method is deprecated. Please switch to GetRootAs."""
        return cls.GetRootAs(buf, offset)
    # DetailedException1
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DetailedException1
    def _ExceptionValue(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint64Flags, o + self._tab.Pos)
        return 0

def DetailedException1Start(builder): builder.StartObject(1)
def DetailedException1Add_ExceptionValue(builder, _ExceptionValue): builder.PrependUint64Slot(0, _ExceptionValue, 0)
def DetailedException1End(builder): return builder.EndObject()


class DetailedException2(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAs(cls, buf, offset=0):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DetailedException2()
        x.Init(buf, n + offset)
        return x

    @classmethod
    def GetRootAsDetailedException2(cls, buf, offset=0):
        """This method is deprecated. Please switch to GetRootAs."""
        return cls.GetRootAs(buf, offset)
    # DetailedException2
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DetailedException2
    def _ExceptionValue(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return None

def DetailedException2Start(builder): builder.StartObject(1)
def DetailedException2Add_ExceptionValue(builder, _ExceptionValue): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(_ExceptionValue), 0)
def DetailedException2End(builder): return builder.EndObject()


class DetailedException3(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAs(cls, buf, offset=0):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DetailedException3()
        x.Init(buf, n + offset)
        return x

    @classmethod
    def GetRootAsDetailedException3(cls, buf, offset=0):
        """This method is deprecated. Please switch to GetRootAs."""
        return cls.GetRootAs(buf, offset)
    # DetailedException3
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DetailedException3
    def AType(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint8Flags, o + self._tab.Pos)
        return 0

    # DetailedException3
    def A(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            from flatbuffers.table import Table
            obj = Table(bytearray(), 0)
            self._tab.Union(obj, o)
            return obj
        return None

def DetailedException3Start(builder): builder.StartObject(2)
def DetailedException3AddAType(builder, aType): builder.PrependUint8Slot(0, aType, 0)
def DetailedException3AddA(builder, a): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(a), 0)
def DetailedException3End(builder): return builder.EndObject()

