# automatically generated by the FlatBuffers compiler, do not modify

# namespace: FlatBuffers

import flatbuffers
from flatbuffers.compat import import_numpy
np = import_numpy()

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
def Start(builder):
    return DetailedException2Start(builder)
def DetailedException2Add_ExceptionValue(builder, _ExceptionValue): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(_ExceptionValue), 0)
def Add_ExceptionValue(builder, _ExceptionValue):
    return DetailedException2Add_ExceptionValue(builder, _ExceptionValue)
def DetailedException2End(builder): return builder.EndObject()
def End(builder):
    return DetailedException2End(builder)