namespace OpenTk_test.FS_Example

open System
open System.Numerics
open OpenTK.Mathematics

module Example =
    let implementsInterface (classType: Type) (interfaceType: Type) =
        classType.IsAssignableFrom(interfaceType)

    let exampleTest =
        let vectorType = typeof<Vector2>.GetType()
        let interfaceType = typeof<IAdditionOperators<Vector2, Vector2, Vector2>>.GetType()

        implementsInterface vectorType interfaceType

    // This code is ok, even though it produces a warning
    let exampleTestMultiplyFloat =
        let vectorType = typeof<Vector2>.GetType()
        let interfaceType = typeof<IMultiplyOperators<Vector2, float32, Vector2>>.GetType()

        implementsInterface vectorType interfaceType

    // The following code does not compile because FS expects the second 
    // parameter of IMultiplyOperators<Vector2, Vector2, Vector2 to be a 
    // float32 for some reason
    //
    // let exampleTestMultiplyVec =
    //    let vectorType = typeof<Vector2>.GetType()
    //    let interfaceType = typeof<IMultiplyOperators<Vector2, Vector2, Vector2>>.GetType()
    //
    //    implementsInterface vectorType interfaceType
