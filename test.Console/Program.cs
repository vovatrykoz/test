using OpenTK.Mathematics;

Quaternion quat = Quaternion.Zero;

Vector3 vec3 = Vector3.One;

var example1 = quat * vec3;

// Uncommenting this results in CS0019: "Operator '*' cannot be applied to operands of type 'Vector3' and 'Quaternion'"
// var example2 = vec3 * quat;

Matrix3 mat3 = Matrix3.Identity;

var example3 = mat3 * vec3;
var example4 = vec3 * mat3;