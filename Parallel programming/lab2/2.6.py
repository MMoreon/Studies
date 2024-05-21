def recurrent_calculation(ui, k, sh):
    # Инициализация начальных значений
    F_prev = 3  # Начальное значение F(ui-1, k, sh-1)
    
    # Рекуррентное вычисление значения F(ui, k, sh)
    for i in range(1, ui + 1):
        for j in range(1, k + 1):
            for l in range(1, sh + 1):
                F_current = F_prev  # Значение F(ui, k, sh) зависит от предыдущего значения
                # Вызов функции F(x, y, z) для вычисления значения F_current
                # Можно добавить соответствующий код для вызова функции F(x, y, z)
                F_prev = F_current  # Обновление значения F_prev для следующей итерации
    
    return F_current

# Пример использования
result = recurrent_calculation(5, 3, 2)  # Пример вызова функции для значений ui=5, k=3, sh=2
print("Результат рекуррентного вычисления F(5, 3, 2):", result)
