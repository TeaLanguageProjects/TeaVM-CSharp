using System.Collections.Concurrent;

namespace TeaVM.Core;

public class TeaByteCodes
{
    public static Dictionary<short,string> ByteCodesSet = new Dictionary<short, string>()
    {
        { 0x00, "NOP" },// Do not do Anything
        
        // Stack Operation: Basic Data Types
        
        { 0x01, "PUSH_NULL" }, // Push NULL to LocalStack
        
        { 0x02, "PUSH_FROM_BYTE_VAR" }, // Push a BYTE Variables To LocalStack
        { 0x03, "PUSH_FROM_SHORT_VAR" }, // Push a SHORT Variables To LocalStack
        { 0x04, "PUSH_FROM_INT_VAR"}, // Push a INT Variables To LocalStack
        { 0x05, "PUSH_FROM_LONG_VAR"}, // Push a LONG Variables To LocalStack
        { 0x06, "PUSH_FROM_FLOAT_VAR"}, // Push a FLOAT Variables To LocalStack
        { 0x07, "PUSH_FROM_DOUBLE_VAR"}, // Push a DOUBLE Variables To LocalStack
        { 0x08, "PUSH_FROM_CHAR_VAR"}, // Push a CHAR Variables To LocalStack
        
        { 0x09, "PUSH_FROM_BYTE_CONST" }, // Push a BYTE Constants To LocalStack
        { 0x0A, "PUSH_FROM_SHORT_CONST" }, // Push a SHORT Constants To LocalStack
        { 0x0B, "PUSH_FROM_INT_CONST"}, // Push a INT Constants To LocalStack
        { 0x0C, "PUSH_FROM_LONG_CONST"}, // Push a LONG Constants To LocalStack
        { 0x0D, "PUSH_FROM_FLOAT_CONST"}, // Push a FLOAT Constants To LocalStack
        { 0x0E, "PUSH_FROM_DOUBLE_CONST"}, // Push a DOUBLE Constants To LocalStack
        { 0x0F, "PUSH_FROM_CHAR_CONST"}, // Push a CHAR Constants To LocalStack
        
        { 0x10, "POP_TO_BYTE_VAR" }, // Pop a BYTE Value To Variables From LocalStack
        { 0x11, "POP_TO_SHORT_VAR" }, // Pop a SHORT Value To Variables From LocalStack
        { 0x12, "POP_TO_INT_VAR"}, // Pop a INT Value To Variables From LocalStack
        { 0x13, "POP_TO_LONG_VAR"}, // Pop a LONG Value To Variables From LocalStack
        { 0x14, "POP_TO_FLOAT_VAR"}, // Pop a FLOAT Value To Variables From LocalStack
        { 0x15, "POP_TO_DOUBLE_VAR"}, // Pop a DOUBLE Value To Variables From LocalStack
        { 0x16, "POP_TO_CHAR_VAR"}, // Pop a CHAR Value To Variables From LocalStack
        
        { 0x17, "PUSH_FROM_BYTE_VMCONST" }, // Push a BYTE Constants To LocalStack From VMConstants
        { 0x18, "PUSH_FROM_SHORT_VMCONST" }, // Push a SHORT Constants To LocalStack From VMConstants
        { 0x19, "PUSH_FROM_INT_VMCONST"}, // Push a INT Constants To LocalStack From VMConstants
        { 0x1A, "PUSH_FROM_LONG_VMCONST"}, // Push a LONG Constants To LocalStack From VMConstants
        { 0x1B, "PUSH_FROM_FLOAT_VMCONST"}, // Push a FLOAT Constants To LocalStack From VMConstants
        { 0x1C, "PUSH_FROM_DOUBLE_VMCONST"}, // Push a DOUBLE Constants To LocalStack From VMConstants
        //{ 0x1C, "PUSH_FROM_CHAR_VMCONST"}, // Push a CHAR Constants To LocalStack From VMConstants 
            
        { 0x1D, "PUSHVM_FROM_BYTE_CONST" }, // Push a BYTE Constants To VMStack
        { 0x1E, "PUSHVM_FROM_SHORT_CONST" }, // Push a SHORT Constants To VMStack
        { 0x1F, "PUSHVM_FROM_INT_CONST"}, // Push a INT Constants To VMStack
        { 0x20, "PUSHVM_FROM_LONG_CONST"}, // Push a LONG Constants To VMStack
        { 0x21, "PUSHVM_FROM_FLOAT_CONST"}, // Push a FLOAT Constants To VMStack
        { 0x22, "PUSHVM_FROM_DOUBLE_CONST"}, // Push a DOUBLE Constants To VMStack
        { 0x23, "PUSHVM_FROM_CHAR_CONST"}, // Push a CHAR Constants To VMStack
        
        { 0x24, "POPVM_TO_BYTE_VAR" }, // Pop a BYTE Value To Variables From VMStack
        { 0x25, "POPVM_TO_SHORT_VAR" }, // Pop a SHORT Value To Variables From VMStack
        { 0x26, "POPVM_TO_INT_VAR"}, // Pop a INT Value To Variables From VMStack
        { 0x27, "POPVM_TO_LONG_VAR"}, // Pop a LONG Value To Variables From VMStack
        { 0x28, "POPVM_TO_FLOAT_VAR"}, // Pop a FLOAT Value To Variables From VMStack
        { 0x29, "POPVM_TO_DOUBLE_VAR"}, // Pop a DOUBLE Value To Variables From VMStack
        { 0x2A, "POPVM_TO_CHAR_VAR"}, // Pop a CHAR Value To Variables From VMStack
            
        { 0x2B, "PUSHVM_FROM_BYTE_VAR" }, // Push a BYTE Variables To VMStack
        { 0x2C, "PUSHVM_FROM_SHORT_VAR" }, // Push a SHORT Variables To VMStack
        { 0x2D, "PUSHVM_FROM_INT_VAR"}, // Push a INT Variables To VMStack
        { 0x2E, "PUSHVM_FROM_LONG_VAR"}, // Push a LONG Variables To VMStack
        { 0x2F, "PUSHVM_FROM_FLOAT_VAR"}, // Push a FLOAT Variables To VMStack
        { 0x30, "PUSHVM_FROM_DOUBLE_VAR"}, // Push a DOUBLE Variables To VMStack
        { 0x31, "PUSHVM_FROM_CHAR_VAR"}, // Push a CHAR Variables To VMStack
        
        { 0x32, "PUSHVM_FROM_BYTE_VMCONST" }, // Push a BYTE Constants To VMStack From VMConstants
        { 0x33, "PUSHVM_FROM_SHORT_VMCONST" }, // Push a SHORT Constants To VMStack From VMConstants
        { 0x34, "PUSHVM_FROM_INT_VMCONST"}, // Push a INT Constants To VMStack From VMConstants
        { 0x35, "PUSHVM_FROM_LONG_VMCONST"}, // Push a LONG Constants To VMStack From VMConstants
        { 0x36, "PUSHVM_FROM_FLOAT_VMCONST"}, // Push a FLOAT Constants To VMStack From VMConstants
        { 0x37, "PUSHVM_FROM_DOUBLE_VMCONST"}, // Push a DOUBLE Constants To VMStack From VMConstants
        { 0x38, "PUSHVM_FROM_CHAR_VMCONST"}, // Push a CHAR Constants To VMStack From VMConstants
        
        // Stack Operation: LINK Type
        { 0x39, "PUSH_FROM_LINK_VAR"}, // Push a LINK Variables To LocalStack
        { 0x3A, "PUSH_FROM_LINK_CONST"}, // Push a LINK Constants To LocalStack
        { 0x3B, "PUSH_FROM_LINK_VMCONST"}, // Push a LINK Constants To LocalStack
        { 0x3C, "POP_TO_LINK_VAR"}, // Pop a LINK Value To Variables From LocalStack
        { 0x3D, "PUSHVM_FROM_LINK_VAR"}, // Push a LINK Variables To VMStack
        { 0x3E, "PUSHVM_FROM_LINK_CONST"}, // Push a LINK Constants To VMStack
        { 0x3F, "PUSHVM_FROM_LINK_VMCONST"}, // Push a LINK Constants To VMStack
        
        { 0x40, "POP_NULL" }, // Pop a Value
        
        // Type Conversion Operation
        
        { 0x41, "INT_TO_FLOAT" }, // Convert the INT type value at the top of the stack to a FLOAT type value
        { 0x42, "INT_TO_LONG" }, // Convert the INT type value at the top of the stack to a LONG type value
        { 0x43, "INT_TO_DOUBLE" }, // Convert the INT type value at the top of the stack to a DOUBLE type value
        { 0x44, "FLOAT_TO_INT" }, // Convert the FLOAT type value at the top of the stack to a INT type value
        { 0x45, "FLOAT_TO_LONG" }, // Convert the FLOAT type value at the top of the stack to a LONG type value
        { 0x46, "FLOAT_TO_DOUBLE" }, // Convert the FLOAT type value at the top of the stack to a DOUBLE type value
        { 0x47, "LONG_TO_INT" }, // Convert the LONG type value at the top of the stack to a INT type value
        { 0x48, "LONG_TO_FLOAT" }, // Convert the LONG type value at the top of the stack to a FLOAT type value
        { 0x49, "LONG_TO_DOUBLE" }, // Convert the LONG type value at the top of the stack to a DOUBLE type value
        { 0x4A, "DOUBLE_TO_INT" }, // Convert the DOUBLE type value at the top of the stack to a INT type value
        { 0x4B, "DOUBLE_TO_FLOAT" }, // Convert the DOUBLE type value at the top of the stack to a FLOAT type value
        { 0x4C, "DOUBLE_TO_LONG" }, // Convert the DOUBLE type value at the top of the stack to a LONG type value
        
        { 0x4D, "INT_TO_BYTE"}, // Truncate the int type value at the top of the stack into a byte type, and then extend it with a sign to an int type value and push it onto the stack
        { 0x4E, "INT_TO_SHORT"}, // Truncate the int type value at the top of the stack into a short type, and then extend it with a sign to an int type value and push it onto the stack
        { 0x4F, "INT_TO_CHAR"}, // Truncate the int type value at the top of the stack into a char type, and then extend it with a sign to an int type value and push it onto the stack
        
        { 0x50, "CHAR_TO_INT"},
        { 0x51, "SHORT_TO_INT"},
        { 0x52, "BYTE_TO_INT"},
        
        // Integer Arithmetic
        
        { 0x53, "IADD"}, // Add the two ints at the top of the stack and push the result onto the stack
        { 0x54, "ISUB"}, // Subtract the two ints at the top of the stack and push the result onto the stack
        { 0x55, "IMUL"}, // Multiply the two ints at the top of the stack and push the result onto the stack
        { 0x56, "IDIV"}, // Divide the two ints at the top of the stack and push the result onto the stack
        { 0x57, "IREM"}, // Remainder of the two ints at the top of the stack and push the result onto the stack
        { 0x58, "INEG"}, // Negate the int at the top of the stack and push the result onto the stack
        
        { 0x59, "LADD"}, // Add the two longs at the top of the stack and push the result onto the stack
        { 0x5A, "LSUB"}, // Subtract the two longs at the top of the stack and push the result onto the stack
        { 0x5B, "LMUL"}, // Multiply the two longs at the top of the stack and push the result onto the stack
        { 0x5C, "LDIV"}, // Divide the two longs at the top of the stack and push the result onto the stack
        { 0x5D, "LREM"}, // Remainder of the two longs at the top of the stack and push the result onto the stack
        { 0x5E, "LNEG"}, // Negate the long at the top of the stack and push the result onto the stack
        
        // Floating Point Operation
        
        { 0x5F, "FADD"}, // Add the two floats at the top of the stack and push the result onto the stack
        { 0x60, "FSUB"}, // Subtract the two floats at the top of the stack and push the result onto the stack
        { 0x61, "FMUL"}, // Multiply the two floats at the top of the stack and push the result onto the stack
        { 0x62, "FDIV"}, // Divide the two floats at the top of the stack and push the result onto the stack
        { 0x63, "FREM"}, // Remainder of the two floats at the top of the stack and push the result onto the stack
        { 0x64, "FNEG"}, // Negate the float at the top of the stack and push the result onto the stack
            
        { 0x65, "DADD"}, // Add the two doubles at the top of the stack and push the result onto the stack
        { 0x66, "DSUB"}, // Subtract the two doubles at the top of the stack and push the result onto the stack
        { 0x67, "DMUL"}, // Multiply the two doubles at the top of the stack and push the result onto the stack
        { 0x68, "DDIV"}, // Divide the two doubles at the top of the stack and push the result onto the stack
        { 0x69, "DREM"}, // Remainder of the two doubles at the top of the stack and push the result onto the stack
        { 0x6A, "DNEG"}, // Negate the double at the top of the stack and push the result onto the stack
        
        // Logical Operations : Shift Operations
        
        { 0x6B, "ISHL"}, // Shift the int at the top of the stack left by the specified number of bits and push the result onto the stack
        { 0x6C, "ISHR"}, // Shift the int at the top of the stack right by the specified number of bits and push the result onto the stack
        { 0x6D, "IUSHR"}, // Unsigned Shift the int at the top of the stack right by the specified number of bits and push the result onto the stack
        { 0x6E, "LSHL"}, // Shift the long at the top of the stack left by the specified number of bits and push the result onto the stack
        { 0x6F, "LSHR"}, // Shift the long at the top of the stack right by the specified number of bits and push the result onto the stack
        { 0x70, "LUSHR"}, // Unsigned Shift the long at the top of the stack right by the specified number of bits and push the result onto the stack
        
        // Logical Operations : Bitwise Boolean Operations
            
        { 0x71, "IAND"}, // Perform a bitwise AND operation on the two ints at the top of the stack and push the result onto the stack
        { 0x72, "IOR"}, // Perform a bitwise OR operation on the two ints at the top of the stack and push the result onto the stack
        { 0x73, "IXOR"}, // Perform a bitwise XOR operation on the two ints at the top of the stack and push the result onto the stack
        { 0x74, "LAND"}, // Perform a bitwise AND operation on the two longs at the top of the stack and push the result onto the stack
        { 0x75, "LOR"}, // Perform a bitwise OR operation on the two longs at the top of the stack and push the result onto the stack
        { 0x76, "LXOR"}, // Perform a bitwise XOR operation on the two longs at the top of the stack and push the result onto the stack
        
        // Control Flow Instruction : Conditional Jump Instruction
        
        { 0x77, "IFEQ"}, // If the int type value at the top of the stack is 0, it jumps
        { 0x78, "IFNE"}, // If the int type value at the top of the stack is not 0, it jumps
        { 0x79, "IFLT"}, // If the int type value at the top of the stack is less than 0, it jumps
        { 0x7A, "IFGE"}, // If the int type value at the top of the stack is greater than or equal to 0, it jumps
        { 0x7B, "IFGT"}, // If the int type value at the top of the stack is greater than 0, it jumps
        { 0x7C, "IFLE"}, // If the int type value at the top of the stack is less than or equal to 0, it jumps
        
        { 0x7D, "IFNULL"}, // If the reference type value at the top of the stack is null, it jumps
        { 0x7E, "IFNOTNULL"}, // If the reference type value at the top of the stack is not null, it jumps
        
        { 0x7F, "GOTO"}, // Jump to the specified label
        
        { 0x80, "IF_ICMPEQ"}, // If the two int type values at the top of the stack are equal, skip
        { 0x81, "IF_ICMPNE"}, // If the two int type values at the top of the stack are not equal, skip
        { 0x82, "IF_ICMPLT"}, // If the two int type values at the top of the stack are less than, skip
        { 0x83, "IF_ICMPGE"}, // If the two int type values at the top of the stack are greater than or equal to, skip
        { 0x84, "IF_ICMPGT"}, // If the two int type values at the top of the stack are greater than, skip
        { 0x85, "IF_ICMPLE"}, // If the two int type values at the top of the stack are less than or equal to, skip
        
        { 0x86, "IF_ACMPEQ"}, // If the two reference type values at the top of the stack are equal, skip
        { 0x87, "IF_ACMPNE"}, // If the two reference type values at the top of the stack are not equal, skip
        
        // Control Flow Instruction : Compare Instruction
        
        { 0x88, "ICMP"}, // Compare the two long type values at the top of the stack, with the former being larger and 1 being pushed onto the stack; Equal, 0 pushed onto the stack; The latter is larger and -1 is pushed onto the stack
        { 0x89, "FCMP"}, // Compare the two float type values at the top of the stack, with the former being larger and 1 being pushed onto the stack; Equal, 0 pushed onto the stack; The latter is larger and -1 is pushed onto the stack
        { 0x8A, "DCMP"}, // Compare the two double type values at the top of the stack, with the former being larger and 1 being pushed onto the stack; Equal, 0 pushed onto the stack; The latter is larger and -1 is pushed onto the stack
        
        // VMStack Operation
        
        { 0x8B, "VM_INT_TO_FLOAT" }, // Convert the INT type value at the top of the VMStack to a FLOAT type value
        { 0x8C, "VM_INT_TO_LONG" }, // Convert the INT type value at the top of the VMStack to a LONG type value
        { 0x8D, "VM_INT_TO_DOUBLE" }, // Convert the INT type value at the top of the VMStack to a DOUBLE type value
        { 0x8E, "VM_FLOAT_TO_INT" }, // Convert the FLOAT type value at the top of the VMStack to a INT type value
        { 0x8F, "VM_FLOAT_TO_LONG" }, // Convert the FLOAT type value at the top of the VMStack to a LONG type value
        { 0x90, "VM_FLOAT_TO_DOUBLE" }, // Convert the FLOAT type value at the top of the VMStack to a DOUBLE type value
        { 0x91, "VM_LONG_TO_INT" }, // Convert the LONG type value at the top of the VMStack to a INT type value
        { 0x92, "VM_LONG_TO_FLOAT" }, // Convert the LONG type value at the top of the VMStack to a FLOAT type value
        { 0x93, "VM_LONG_TO_DOUBLE" }, // Convert the LONG type value at the top of the VMStack to a DOUBLE type value
        { 0x94, "VM_DOUBLE_TO_INT" }, // Convert the DOUBLE type value at the top of the VMStack to a INT type value
        { 0x95, "VM_DOUBLE_TO_FLOAT" }, // Convert the DOUBLE type value at the top of the VMStack to a FLOAT type value
        { 0x96, "VM_DOUBLE_TO_LONG" }, // Convert the DOUBLE type value at the top of the VMStack to a LONG type value
        
        { 0x97, "VM_INT_TO_BYTE" }, // Convert the INT type value at the top of the VMStack to a BYTE type value
        { 0x98, "VM_INT_TO_SHORT" }, // Convert the INT type value at the top of the VMStack to a SHORT type value
        { 0x99, "VM_INT_TO_CHAR" }, // Convert the INT type value at the top of the VMStack to a CHAR type value
        
        { 0x9A, "VM_CHAR_TO_INT" }, // Convert the CHAR type value at the top of the VMStack to a INT type value
        { 0x9B, "VM_SHORT_TO_INT" }, // Convert the SHORT type value at the top of the VMStack to a INT type value
        { 0x9C, "VM_BYTE_TO_INT" }, // Convert the BYTE type value at the top of the VMStack to a INT type value
        
        { 0x9D, "VM_IADD"}, // Add the two ints at the top of the VMStack and push the result onto the VMStack
        { 0x9E, "VM_ISUB"}, // Subtract the two ints at the top of the VMStack and push the result onto the VMStack
        { 0x9F, "VM_IMUL"}, // Multiply the two ints at the top of the VMStack and push the result onto the VMStack
        { 0xA0, "VM_IDIV"}, // Divide the two ints at the top of the VMStack and push the result onto the VMStack
        { 0xA1, "VM_IREM"}, // Remainder of the two ints at the top of the VMStack and push the result onto the VMStack
        { 0xA2, "VM_INEG"}, // Negate the int at the top of the VMStack and push the result onto the VMStack
        
        { 0xA3, "VM_LADD"}, // Add the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xA4, "VM_LSUB"}, // Subtract the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xA5, "VM_LMUL"}, // Multiply the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xA6, "VM_LDIV"}, // Divide the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xA7, "VM_LREM"}, // Remainder of the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xA8, "VM_LNEG"}, // Negate the long at the top of the VMStack and push the result onto the VMStack
         
        { 0xA9, "VM_FADD"}, // Add the two floats at the top of the VMStack and push the result onto the VMStack
        { 0xAA, "VM_FSUB"}, // Subtract the two floats at the top of the VMStack and push the result onto the VMStack
        { 0xAB, "VM_FMUL"}, // Multiply the two floats at the top of the VMStack and push the result onto the VMStack
        { 0xAC, "VM_FDIV"}, // Divide the two floats at the top of the VMStack and push the result onto the VMStack
        { 0xAD, "VM_FREM"}, // Remainder of the two floats at the top of the VMStack and push the result onto the VMStack
        { 0xAE, "VM_FNEG"}, // Negate the float at the top of the VMStack and push the result onto the VMStack
        
        { 0xAF, "VM_DADD"}, // Add the two doubles at the top of the VMStack and push the result onto the VMStack
        { 0xB0, "VM_DSUB"}, // Subtract the two doubles at the top of the VMStack and push the result onto the VMStack
        { 0xB1, "VM_DMUL"}, // Multiply the two doubles at the top of the VMStack and push the result onto the VMStack
        { 0xB2, "VM_DDIV"}, // Divide the two doubles at the top of the VMStack and push the result onto the VMStack
        { 0xB3, "VM_DREM"}, // Remainder of the two doubles at the top of the VMStack and push the result onto the VMStack
        { 0xB4, "VM_DNEG"}, // Negate the double at the top of the VMStack and push the result onto the VMStack
        
        { 0xB5, "VM_ISHL"}, // Shift the int at the top of the VMStack left by the specified number of bits and push the result onto the VMStack
        { 0xB6, "VM_ISHR"}, // Shift the int at the top of the VMStack right by the specified number of bits and push the result onto the VMStack
        { 0xB7, "VM_IUSHR"}, // Unsigned Shift the int at the top of the VMStack right by the specified number of bits and push the result onto the VMStack
        { 0xB8, "VM_LSHL"}, // Shift the long at the top of the VMStack left by the specified number of bits and push the result onto the VMStack
        { 0xB9, "VM_LSHR"}, // Shift the long at the top of the VMStack right by the specified number of bits and push the result onto the VMStack
        { 0xBA, "VM_LUSHR"}, // Unsigned Shift the long at the top of the VMStack right by the specified number of bits and push the result onto the VMStack
        
        { 0xBB, "VM_IAND"}, // Perform a bitwise AND operation on the two ints at the top of the VMStack and push the result onto the VMStack
        { 0xBC, "VM_IOR"}, // Perform a bitwise OR operation on the two ints at the top of the VMStack and push the result onto the VMStack
        { 0xBD, "VM_IXOR"}, // Perform a bitwise XOR operation on the two ints at the top of the VMStack and push the result onto the VMStack
        { 0xBE, "VM_LAND"}, // Perform a bitwise AND operation on the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xBF, "VM_LOR"}, // Perform a bitwise OR operation on the two longs at the top of the VMStack and push the result onto the VMStack
        { 0xC0, "VM_LXOR"}, // Perform a bitwise XOR operation on the two longs at the top of the VMStack and push the result onto the VMStack
        
        { 0xC1, "VM_IFEQ"}, // If the int type value at the top of the VMStack is 0, it jumps
        { 0xC2, "VM_IFNE"}, // If the int type value at the top of the VMStack is not 0, it jumps
        { 0xC3, "VM_IFLT"}, // If the int type value at the top of the VMStack is less than 0, it jumps
        { 0xC4, "VM_IFGE"}, // If the int type value at the top of the VMStack is greater than or equal to 0, it jumps
        { 0xC5, "VM_IFGT"}, // If the int type value at the top of the VMStack is greater than 0, it jumps
        { 0xC6, "VM_IFLE"}, // If the int type value at the top of the VMStack is less than or equal to 0, it jumps
        
        { 0xC7, "VM_IFNULL"}, // If the reference type value at the top of the VMStack is null, it jumps
        { 0xC8, "VM_IFNOTNULL"}, // If the reference type value at the top of the VMStack is not null, it jumps
        
        { 0xC9, "VM_IF_ICMPEQ"}, // If the two int type values at the top of the VMStack are equal, skip
        { 0xCA, "VM_IF_ICMPNE"}, // If the two int type values at the top of the VMStack are not equal, skip
        { 0xCB, "VM_IF_ICMPLT"}, // If the two int type values at the top of the VMStack are less than, skip
        { 0xCC, "VM_IF_ICMPGE"}, // If the two int type values at the top of the VMStack are greater than or equal to, skip
        { 0xCD, "VM_IF_ICMPGT"}, // If the two int type values at the top of the VMStack are greater than, skip
        { 0xCE, "VM_IF_ICMPLE"}, // If the two int type values at the top of the VMStack are less than or equal to, skip
        
        { 0xCF, "VM_IF_ACMPEQ"}, // If the two reference type values at the top of the VMStack are equal, skip
        { 0xD0, "VM_IF_ACMPNE"}, // If the two reference type values at the top of the VMStack are not equal, skip
        
        { 0xD1, "VM_ICMP"}, // Compare the two long type values at the top of the VMStack, with the former being larger and 1 being pushed onto the VMStack; Equal, 0 pushed onto the VMStack; The latter is larger and -1 is pushed onto the VMStack
        { 0xD2, "VM_FCMP"}, // Compare the two float type values at the top of the VMStack, with the former being larger and 1 being pushed onto the VMStack; Equal, 0 pushed onto the VMStack; The latter is larger and -1 is pushed onto the VMStack
        { 0xD3, "VM_DCMP"}, // Compare the two double type values at the top of the VMStack, with the former being larger and 1 being pushed onto the VMStack; Equal, 0 pushed onto the VMStack; The latter is larger and -1 is pushed onto the VMStack
        
        // Object Operation Instructions
        
        { 0xD4, "NEW"}, // Create a new object of the specified class and push its link to LocalStack
        { 0xD5, "VM_NEW"}, // Create a new object of the specified class and push its link to VMStack
        
        { 0xD6, "CHECK_CAST"}, // Type Cast
        { 0xD7, "INSTANCE_OF"}, // Determine The Type
        { 0xD8, "GET_FIELD"}, 
        { 0xD9, "PUT_FIELD"}, 
        { 0xDA, "GET_STATIC"}, 
        { 0xDB, "PUT_STATIC"}, 
        
        // Array Operation Instructions
        
        { 0xDC, "NEW_ARRAY"}, // Create a new array of the specified type and push its link to LocalStack
        { 0xDD, "VM_NEW_ARRAY"}, // Create a new array of the specified type and push its link to VMStack
        
        { 0xDC, "NEW_TYPE_ARRAY"}, // Create an array of reference types and push its link to LocalStack
        { 0xDD, "VM_NEW_TYPE_ARRAY"}, // Create an array of reference types and push its link to VMStack
        
        { 0xDE, "ARRAY_LENGTH"}, // Get the length of the array at the top of the LocalStack
        { 0xDF, "VM_ARRAY_LENGTH"}, // Get the length of the array at the top of the VMStack
        
        { 0xE0, "ARRAY_GET"}, // Get the value of the array at the specified index and push it to the LocalStack
        { 0xE1, "VM_ARRAY_GET"}, // Get the value of the array at the specified index and push it to the VMStack
        
        { 0xE2, "ARRAY_PUT"}, // Set the value of the array at the specified index and push it to the LocalStack
        { 0xE3, "VM_ARRAY_PUT"}, // Set the value of the array at the specified index and push it to the VMStack
        
        { 0xE4, "MULTI_ARRAY"}, // Create an array of dimension dimensions and push its link to LocalStack
        { 0xE5, "VM_MULTI_ARRAY"}, // Create an array of dimension dimensions and push its link to VMStack
        
        { 0xE6, "MULTI_TYPE_ARRAY"}, // Create an array of dimension dimensions and push its link to LocalStack
        { 0xE7, "VM_MULTI_TYPE_ARRAY"}, // Create an array of dimension dimensions and push its link to VMStack
        
        // Method Call Instructions
        
        { 0xE8, "INVOKE_VIRTUAL"}, // Invoke the specified method and push the result to the LocalStack
        { 0xE9, "VM_INVOKE_VIRTUAL"}, // Invoke the specified method and push the result to the VMStack
        
        { 0xEA, "INVOKE_STATIC"}, // Invoke the specified static method and push the result to the LocalStack
        { 0xEB, "VM_INVOKE_STATIC"}, // Invoke the specified static method and push the result to the VMStack
        
        { 0xEC, "INVOKE_SPECIAL"}, // Invoke the specified special method and push the result to the LocalStack
        { 0xED, "VM_INVOKE_SPECIAL"}, // Invoke the specified special method and push the result to the VMStack
        
        { 0xEE, "INVOKE_INTERFACE"}, // Invoke the specified interface method and push the result to the LocalStack
        { 0xEF, "VM_INVOKE_INTERFACE"}, // Invoke the specified interface method and push the result to the VMStack
        
        // Method Return Istruction
        
        { 0xF0, "RETURN"}, // The void function returns
        { 0xF1, "RETURN_INT"}, // Returns a value of type int (LocalStack Top)
        { 0xF2, "RETURN_LONG"}, // Returns a value of type long (LocalStack Top)
        { 0xF3, "RETURN_FLOAT"}, // Returns a value of type float (LocalStack Top)
        { 0xF4, "RETURN_DOUBLE"}, // Returns a value of type double (LocalStack Top)
        { 0xF5, "RETURN_OBJECT"}, // Returns a value of type object (LocalStack Top)
        
        { 0xF6, "VM_RETURN"}, // The void function returns
        { 0xF7, "VM_RETURN_INT"}, // Returns a value of type int (VMStack Top)
        { 0xF8, "VM_RETURN_LONG"}, // Returns a value of type long (VMStack Top)
        { 0xF9, "VM_RETURN_FLOAT"}, // Returns a value of type float (VMStack Top)
        { 0xFA, "VM_RETURN_DOUBLE"}, // Returns a value of type double (VMStack Top)
        { 0xFB, "VM_RETURN_OBJECT"}, // Returns a value of type object (VMStack Top)
        
        // Control Flow Instructions : Exceptions And Finally
        
        { 0xFC, "THROW"}, // Throw an exception
        { 0xFD, "CATCH"}, // Catch an exception
        { 0xFE, "FINALLY"}, // Throw an Finally
        { 0xFF, "JSR"}, // Jump to the suboutine

        // Bytecode that was previously missed
        { 0x100, "PUSH_FROM_CHAR_VMCONST"}, // Push a CHAR Constants To LocalStack From VMConstants
            
        // Thread Synchronization Instruction

        { 0x101, "MONITOR_ENTER"}, // Enter a monitor
        { 0x102, "MONITOR_EXIT"}, // Exit a monitor
        
        // Debugging Instruction
        
        { 0x103, "BREAKPOINT"}, // Breakpoint
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    };
}