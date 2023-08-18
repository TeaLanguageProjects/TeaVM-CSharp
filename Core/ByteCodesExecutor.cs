using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class ByteCodesExecutor
    {
        // This object parses bytecode and performs corresponding operations

        public Klass SourceKlass = null;
        public VM SourceVM;
        public int PC = 0;
        public const int LONG_BYTES = 8;

        public ByteCodesExecutor(Klass sourceKlass, VM sourceVM)
        {
            this.SourceKlass = sourceKlass;
            this.SourceVM = sourceVM;
        }

        public void Execute()
        {
            while (PC < SourceKlass.LocalData.ByteCodes.Length)
            {
                // Read Two Bytes from ByteCodes as a OpCode
                byte[] opCode = new byte[2];
                opCode[0] = SourceKlass.LocalData.ByteCodes[PC];
                opCode[1] = SourceKlass.LocalData.ByteCodes[PC + 1];
                PC += 2;

                // byte[] opCode => int opCode
                int opCodeInt = BitConverter.ToUInt16(opCode, 0);
                // print hex String 
                //Console.WriteLine(opCodeInt.ToString("X"));

                try
                {
                    // Execute OpCode
                    switch (opCodeInt)
                    {
                        // NOP
                        case 0x00:
                        {
                            break;
                        }
                        case 0x01:
                        {
                            TeaData nullData = TeaData.NewNormalData();
                            nullData.Type = TeaTypes.NULL;
                            nullData.SourceKlass = SourceKlass;
                            nullData.Data = new byte[] { };
                            nullData.IsList = false;

                            SourceKlass.LocalStack.Push(nullData);
                            break;
                        }
                        case 0x02:
                        {
                            // Read 8 bits data from ByteCodes as a long
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.BYTE)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x03:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.SHORT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x04:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.INT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x05:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LONG)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x06:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.FLOAT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x07:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.DOUBLE)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x08:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.CHAR)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x09:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.BYTE)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x0A:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.SHORT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x0B:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.INT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x0C:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LONG)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x0D:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.FLOAT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x0E:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.DOUBLE)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x0F:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.CHAR)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x10:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;

                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.BYTE)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x11:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.SHORT)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x12:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x13:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.LONG)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x14:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.FLOAT)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x15:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.DOUBLE)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x16:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.CHAR)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x17:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.BYTE)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x18:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.SHORT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x19:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.INT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x1A:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LONG)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x1B:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.FLOAT)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x1C:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.DOUBLE)
                                {
                                    SourceKlass.LocalStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x1D:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.BYTE)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x1E:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.SHORT)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x1F:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.INT)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x20:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LONG)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x21:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.FLOAT)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x22:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.DOUBLE)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x23:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.CHAR)
                                {
                                    SourceVM.VMStack.Push(varData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceVM.VMStack.Push(nullData);
                                }
                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceVM.VMStack.Push(nullData);
                            }
                            break;
                        }
                        case 0x24:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.BYTE)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x25:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.SHORT)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x26:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x27:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.LONG)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x28:
                        {byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.FLOAT)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x29:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.DOUBLE)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);

                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }
                        case 0x2A:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData stackData;
                            bool isSuccess = SourceVM.VMStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.CHAR)
                                {
                                    SourceKlass.LocalVariables.AddOrUpdate(indexId, stackData,
                                        (existingKey, existingValue) => stackData);
                                }
                                else
                                {
                                    TeaData nullData = TeaData.NewNormalData();
                                    nullData.Type = TeaTypes.NULL;
                                    nullData.SourceKlass = SourceKlass;
                                    nullData.Data = new byte[] { };
                                    nullData.IsList = false;

                                    SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                                }

                            }
                            else
                            {
                                TeaData nullData = TeaData.NewNormalData();
                                nullData.Type = TeaTypes.NULL;
                                nullData.SourceKlass = SourceKlass;
                                nullData.Data = new byte[] { };
                                nullData.IsList = false;

                                SourceKlass.LocalVariables.TryAdd(indexId, nullData);
                            }
                            break;
                        }














                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}