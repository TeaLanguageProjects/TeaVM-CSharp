﻿using System;
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
                        case 0x2B:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
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
                        case 0x2C:
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
                        case 0x2D:
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
                        case 0x2E:
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
                        case 0x2F:
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
                        case 0x30:
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
                        case 0x31:
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
                        case 0x32:
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
                        case 0x33:
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
                        case 0x34:
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
                        case 0x35:
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
                        case 0x36:
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
                        case 0x37:
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
                        case 0x38:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
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
                        case 0x39:
                        {
                            // Read 8 bits data from ByteCodes as a long
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LINK)
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
                        case 0x3A:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LINK)
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
                        case 0x3B:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LINK)
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
                        case 0x3C:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;

                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.LINK)
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
                        case 0x3D:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalVariables.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LINK)
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
                        case 0x3E:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceKlass.LocalConstants.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LINK)
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
                        case 0x3F:
                        {
                            byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            long indexId = BitConverter.ToInt64(longData, 0);
                            PC += LONG_BYTES;


                            TeaData varData = new TeaData();
                            bool isSuccess = SourceVM.VMConstant.TryGetValue(indexId, out varData);
                            if (isSuccess)
                            {
                                if (varData.Type == TeaTypes.LINK)
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
                        case 0x40:
                        {
                            // byte[] longData = SourceKlass.LocalData.ReadBytes(PC, LONG_BYTES);
                            // long indexId = BitConverter.ToInt64(longData, 0);
                            // PC += LONG_BYTES;

                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            break;
                        }
                        case 0x41:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    stackData.Type = TeaTypes.FLOAT;
                                    stackData.Data = BitConverter.GetBytes((float)BitConverter.ToInt32(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x42:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    stackData.Type = TeaTypes.LONG;
                                    stackData.Data = BitConverter.GetBytes((long)BitConverter.ToInt32(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x43:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    stackData.Type = TeaTypes.DOUBLE;
                                    stackData.Data = BitConverter.GetBytes((double)BitConverter.ToInt32(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x44:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.FLOAT)
                                {
                                    stackData.Type = TeaTypes.INT;
                                    stackData.Data = BitConverter.GetBytes((int)BitConverter.ToSingle(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x45:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.FLOAT)
                                {
                                    stackData.Type = TeaTypes.LONG;
                                    stackData.Data = BitConverter.GetBytes((long)BitConverter.ToSingle(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x46:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.FLOAT)
                                {
                                    stackData.Type = TeaTypes.DOUBLE;
                                    stackData.Data = BitConverter.GetBytes((double)BitConverter.ToSingle(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x47:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.LONG)
                                {
                                    stackData.Type = TeaTypes.INT;
                                    stackData.Data = BitConverter.GetBytes((int)BitConverter.ToInt64(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x48:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.LONG)
                                {
                                    stackData.Type = TeaTypes.FLOAT;
                                    stackData.Data = BitConverter.GetBytes((float)BitConverter.ToInt64(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x49:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.LONG)
                                {
                                    stackData.Type = TeaTypes.DOUBLE;
                                    stackData.Data = BitConverter.GetBytes((double)BitConverter.ToInt64(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x4A:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.DOUBLE)
                                {
                                    stackData.Type = TeaTypes.INT;
                                    stackData.Data = BitConverter.GetBytes((int)BitConverter.ToDouble(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x4B:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.DOUBLE)
                                {
                                    stackData.Type = TeaTypes.FLOAT;
                                    stackData.Data = BitConverter.GetBytes((float)BitConverter.ToDouble(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x4C:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.DOUBLE)
                                {
                                    stackData.Type = TeaTypes.LONG;
                                    stackData.Data = BitConverter.GetBytes((long)BitConverter.ToDouble(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x4D:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    stackData.Type = TeaTypes.BYTE;
                                    stackData.Data = BitConverter.GetBytes((byte)BitConverter.ToInt32(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x4E:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    stackData.Type = TeaTypes.SHORT;
                                    stackData.Data = BitConverter.GetBytes((short)BitConverter.ToInt32(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x4F:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.INT)
                                {
                                    stackData.Type = TeaTypes.CHAR;
                                    stackData.Data = BitConverter.GetBytes((char)BitConverter.ToInt32(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x50:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.CHAR)
                                {
                                    stackData.Type = TeaTypes.INT;
                                    stackData.Data = BitConverter.GetBytes((int)BitConverter.ToChar(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x51:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.SHORT)
                                {
                                    stackData.Type = TeaTypes.INT;
                                    stackData.Data = BitConverter.GetBytes((int)BitConverter.ToInt16(stackData.Data));
                                    SourceKlass.LocalStack.Push(stackData);
                                    
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
                        case 0x52:
                        {
                            TeaData stackData;
                            bool isSuccess = SourceKlass.LocalStack.TryPop(out stackData);
                            if (isSuccess)
                            {
                                if (stackData.Type == TeaTypes.BYTE)
                                {
                                    stackData.Type = TeaTypes.INT;
                                    if (stackData.Data.Length == 0)
                                    {
                                        stackData.Data = BitConverter.GetBytes((int)0);
                                    }
                                    stackData.Data = BitConverter.GetBytes((int)stackData.Data[0]);
                                    SourceKlass.LocalStack.Push(stackData);
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
                        case 0x53:
                        {
                            TeaData stackData1;
                            TeaData stackData2;
                            bool isSuccess1 = SourceKlass.LocalStack.TryPop(out stackData1);
                            bool isSuccess2 = SourceKlass.LocalStack.TryPop(out stackData2);
                            if (isSuccess1 && isSuccess2)
                            {
                                if (stackData1.Type == TeaTypes.INT && stackData2.Type == TeaTypes.INT)
                                {
                                    int int1 = BitConverter.ToInt32(stackData1.Data);
                                    int int2 = BitConverter.ToInt32(stackData2.Data);
                                    int result = int1 + int2;
                                    TeaData resultData = TeaData.NewNormalData();
                                    resultData.Type = TeaTypes.INT;
                                    resultData.SourceKlass = SourceKlass;
                                    resultData.Data = BitConverter.GetBytes(result);
                                    resultData.IsList = false;
                                    
                                    SourceKlass.LocalStack.Push(resultData);
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