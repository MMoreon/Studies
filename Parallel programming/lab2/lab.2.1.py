import concurrent.futures

# Функция для вычисления многочлена в точке схемой Горнера
def calculate_polynomial(coefficients, x):
    result = coefficients[0]
    for coeff in coefficients[1:]:
        result = result * x + coeff
    return result

if __name__ == "__main__":
    try:
        coefficients = [3, 4, 2, 2, 1]  # Коэффициенты многочлена в порядке от старшей степени к младшей
        x_value = 2  # Точка, в которой будем вычислять многочлен

        with concurrent.futures.ThreadPoolExecutor() as executor:
            # Вычисляем значение многочлена в точке
            future = executor.submit(calculate_polynomial, coefficients, x_value)
            result = future.result()

        print(f"Значение многочлена в точке {x_value} равно {result}")
    except Exception as e:
        print(f"Произошла ошибка: {e}")