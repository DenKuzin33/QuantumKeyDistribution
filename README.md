# QuantumKeyDistribution
Эмулятор протокола квантового распределения ключей.
Основной класс Photon.cs содержит в себе значение отдельного фотона, которое задается в конструкторе при создании нового экземпляра.
Для имитации поляризации фотона используется операция XoR по значению базиса.
При измерении значения конкретного фотона повторно используется XoR по случайному базису и значение фотона меняется. 
Класс Party.cs представляет собой одного из участников канала.
В этом классе может находиться массив фотонов (только для Алисы).
Остальные участники просто обращаются к ее массиву фотонов для их измерения.
