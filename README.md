# Herdin_nor_saputra_-_Tugas_7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)

resource load
- audio yang di load ada 4 tetapi yang digunaka hanya satu.
- jadi di script audioManager hanya membuat  satu audioResource dan meload satu file audioclip secara acak saja.

object pooling
- object moshroom di spawn secara terus menerus
- object moshrom dibuat menjadi object pooling dan haya sebanya 200 object, object akan tidak aktif setelah 3detik di panggil dari objectpollingnya.
