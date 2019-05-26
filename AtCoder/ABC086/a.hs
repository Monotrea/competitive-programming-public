import Data.Bool (bool)

main :: IO ()
main = do
    [a, b] <- map (read . return) <$> getLine :: [Int]
    putStr $ bool "Odd" "Even" $ even $ a*b