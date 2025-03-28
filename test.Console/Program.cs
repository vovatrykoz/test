using OpenTK.Mathematics;

Quaternion quat = Quaternion.Zero;

Vector3 vec3 = Vector3.One;

var example1 = quat * vec3; // This is fine

// Uncommenting this results in CS0019: "Operator '*' cannot be applied to operands of type 'Vector3' and 'Quaternion'"
// var example2 = vec3 * quat;

Matrix3 mat3 = Matrix3.Identity;

var example3 = mat3 * vec3; // resolves to Vector3 Matrix3.operator *(Matrix3 mat, Vector3 vec), defined in Matrix3.cs
var example4 = vec3 * mat3; // resolves to Vector3 Vector3.operator *(Vector3 vec, Matrix3 mat), defined in Vector3.cs