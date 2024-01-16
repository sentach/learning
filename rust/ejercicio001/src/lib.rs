pub fn sumar(numero: i64) -> usize {
    0
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_works1() {
        let result = sumar(0);
        assert_eq!(result, 0);
    }

    #[test]
    fn it_works2() {
        let result = sumar(16);
        assert_eq!(result, 7);
    }

    #[test]
    fn it_works3() {
        let result = sumar(1283);
        assert_eq!(result, 5);
    }

    #[test]
    fn it_works4() {
        let result = sumar(99765);
        assert_eq!(result, 9);
    }

    #[test]
    fn it_works5() {
        let result = sumar(493193);
        assert_eq!(result, 2);
    }
}
