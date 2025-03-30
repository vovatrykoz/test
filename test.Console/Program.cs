using OpenTK.Mathematics;

Quaternion quat = Quaternion.Zero;

Vector3 vec3 = Vector3.One;

var example1 = quat * vec3; // This is fine

// Uncommenting this results in CS0019: "Operator '*' cannot be applied to operands of type 'Vector3' and 'Quaternion'"
// var example2 = vec3 * quat;

Matrix3 mat3 = Matrix3.Identity;

var example3 = mat3 * vec3; // resolves to Vector3 Matrix3.operator *(Matrix3 mat, Vector3 vec), defined in Matrix3.cs
var example4 = vec3 * mat3; // resolves to Vector3 Vector3.operator *(Vector3 vec, Matrix3 mat), defined in Vector3.cs



// Identity matrices

var mat3x2 = new Matrix3x2(new Vector2(1,2), new Vector2(3, 4), new Vector2(5, 6));
var identityMultiplicationResult3x2 = Matrix3.Identity * mat3x2;

Console.WriteLine($"Identity matrix\n{Matrix3.Identity}\nmultiplied by a 3x2 matrix:\n{mat3x2}\n\nIdentity multiplication result:\n{identityMultiplicationResult3x2}\n\n");

var mat2x3 = new Matrix2x3(new Vector3(1, 2, 3), new Vector3(4, 5, 6));
var identityMultiplicationResult2x3 = Matrix2.Identity * mat2x3;

Console.WriteLine($"Identity matrix\n{Matrix2.Identity}\nmultiplied by a 2x3 matrix:\n{mat2x3}\n\nIdentity multiplication result:\n{identityMultiplicationResult2x3}");