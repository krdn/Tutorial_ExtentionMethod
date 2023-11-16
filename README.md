# Tutorial_ExtentionMethod

## Extention Method(확장 메서드)


확장명 메서드를 사용하면 새 파생 형식을 만들거나 다시 컴파일하거나 원래 형식을 수정하지 않고도 기존 형식에 메서드를 "추가"할 수 있습니다. 확장 메서드는 정적 메서드이지만 확장 형식의 인스턴스 메서드인 것처럼 호출됩니다. C#, F# 및 Visual Basic에서 작성된 클라이언트 코드의 경우 확장명 메서드를 호출하는 것과 형식에 정의된 메서드를 호출하는 데는 명백한 차이가 없습니다.

가장 일반적인 확장명 메서드는 쿼리 기능을 기존 [System.Collections.IEnumerable](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.ienumerable) 및 [System.Collections.Generic.IEnumerable<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerable-1) 형식에 추가하는 LINQ 표준 쿼리 연산자입니다. 표준 쿼리 연산자를 사용하려면 `using System.Linq` 지시문을 사용해서 먼저 범위를 지정합니다. 그러면 [IEnumerable<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerable-1)을 구현하는 모든 형식에 [GroupBy](https://learn.microsoft.com/ko-kr/dotnet/api/system.linq.enumerable.groupby), [OrderBy](https://learn.microsoft.com/ko-kr/dotnet/api/system.linq.enumerable.orderby), [Average](https://learn.microsoft.com/ko-kr/dotnet/api/system.linq.enumerable.average) 등의 인스턴스 메서드가 있는 것처럼 나타납니다. [List<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.list-1) 또는 [Array](https://learn.microsoft.com/ko-kr/dotnet/api/system.array)와 같은 [IEnumerable<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerable-1) 형식의 인스턴스 뒤에 "dot"를 입력하면 IntelliSense 문 완성에서 이러한 추가 메서드를 볼 수 있습니다.



https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/classes-and-structs/extension-methods?redirectedfrom=MSDN#example