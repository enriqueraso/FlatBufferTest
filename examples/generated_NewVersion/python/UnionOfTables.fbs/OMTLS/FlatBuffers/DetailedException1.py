# automatically generated by the FlatBuffers compiler, do not modify

# namespace: FlatBuffers

import flatbuffers
from flatbuffers.compat import import_numpy
np = import_numpy()

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
def Start(builder):
    return DetailedException1Start(builder)
def DetailedException1Add_ExceptionValue(builder, _ExceptionValue): builder.PrependUint64Slot(0, _ExceptionValue, 0)
def Add_ExceptionValue(builder, _ExceptionValue):
    return DetailedException1Add_ExceptionValue(builder, _ExceptionValue)
def DetailedException1End(builder): return builder.EndObject()
def End(builder):
    return DetailedException1End(builder)