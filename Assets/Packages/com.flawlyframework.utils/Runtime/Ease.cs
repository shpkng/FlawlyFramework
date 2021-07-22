// Author: wuchenyang(shpkng@gmail.com)

// Math functions are from https://easings.net/cn. 
// Check the website for visualised illustrations.

using UnityEngine;

namespace FF.Utils
{
    public static class Ease
    {
        [System.Runtime.CompilerServices.MethodImpl(
            System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static float Clamp01(float t, float start, float end) => (t - start) / (end - start);

        public static float InSine(float t) => 1 - Mathf.Cos(Mathf.Clamp01(t) * Mathf.PI / 2);
        public static float InSine(float t, float start, float end) => InSine(Clamp01(t, start, end));
        public static float OutSine(float t) => Mathf.Sin(Mathf.Clamp01(t) * Mathf.PI / 2);
        public static float OutSine(float t, float start, float end) => OutSine(Clamp01(t, start, end));
        public static float InOutSine(float t) => -(Mathf.Cos(Mathf.PI * t) - 1) / 2;
        public static float InOutSine(float t, float start, float end) => InOutSine(Clamp01(t, start, end));
        public static float InCubic(float t) => t * t * t;
        public static float InCubic(float t, float start, float end) => InCubic(Clamp01(t, start, end));
        public static float OutCubic(float t) => 1 - Mathf.Pow(1 - t, 3);
        public static float OutCubic(float t, float start, float end) => OutCubic(Clamp01(t, start, end));
        public static float InOutCubic(float t) => t < 0.5 ? 4 * t * t * t : 1 - Mathf.Pow(-2 * t + 2, 3) / 2;
        public static float InOutCubic(float t, float start, float end) => InOutCubic(Clamp01(t, start, end));
        public static float InQuint(float t) => t * t * t * t * t;
        public static float InQuint(float t, float start, float end) => InQuint(Clamp01(t, start, end));
        public static float OutQuint(float t) => 1 - Mathf.Pow(1 - t, 5);
        public static float OutQuint(float t, float start, float end) => OutQuint(Clamp01(t, start, end));
        public static float InOutQuint(float t) => t < 0.5 ? 16 * t * t * t * t * t : 1 - Mathf.Pow(-2 * t + 2, 5) / 2;
        public static float InOutQuint(float t, float start, float end) => InOutQuint(Clamp01(t, start, end));
        public static float InCircles(float t) => 1 - Mathf.Sqrt(1 - Mathf.Pow(t, 2));
        public static float InCircles(float t, float start, float end) => InCircles(Clamp01(t, start, end));
        public static float OutCircle(float t) => Mathf.Sqrt(1 - Mathf.Pow(t - 1, 2));
        public static float OutCircle(float t, float start, float end) => OutCircle(Clamp01(t, start, end));

        public static float InOutCircle(float t) =>
            t < 0.5
                ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * t, 2))) / 2
                : (Mathf.Sqrt(1 - Mathf.Pow(-2 * t + 2, 2)) + 1) / 2;

        public static float InOutCircle(float t, float start, float end) => InOutCircle(Clamp01(t, start, end));

        public static float InElastic(float t)
        {
            var c4 = (2 * Mathf.PI) / 3;
            return t is 0 ? 0 : t is 1 ? 1 : -Mathf.Pow(2, 10 * t - 10) * Mathf.Sin((t * 10 - 10.75f) * c4);
        }

        public static float InElastic(float t, float start, float end) => InElastic(Clamp01(t, start, end));

        public static float OutElastic(float t)
        {
            var c4 = (2 * Mathf.PI) / 3;

            return t == 0
                ? 0
                : t == 1
                    ? 1
                    : Mathf.Pow(2, -10 * t) * Mathf.Sin((t * 10 - 0.75f) * c4) + 1;
        }

        public static float OutElastic(float t, float start, float end) => OutElastic(Clamp01(t, start, end));

        public static float InOutElastic(float t)
        {
            var c5 = (2 * Mathf.PI) / 4.5f;

            return t == 0
                ? 0
                : t == 1
                    ? 1
                    : t < 0.5
                        ? -(Mathf.Pow(2, 20 * t - 10) * Mathf.Sin((20 * t - 11.125f) * c5)) / 2
                        : (Mathf.Pow(2, -20 * t + 10) * Mathf.Sin((20 * t - 11.125f) * c5)) / 2 + 1;
        }

        public static float InOutElastic(float t, float start, float end) => InOutElastic(Clamp01(t, start, end));

        public static float InQuad(float x)
        {
            return 0;
        }

        public static float OutQuad(float x)
        {
            return 0;
        }

        public static float InOutQuad(float x)
        {
            return 0;
        }

        public static float InQuart(float x)
        {
            return 0;
        }

        public static float OutQuart(float x)
        {
            return 0;
        }

        public static float InOutQuart(float x)
        {
            return 0;
        }

        public static float InExpo(float x)
        {
            return 0;
        }

        public static float OutExpo(float x)
        {
            return 0;
        }

        public static float InOutExpo(float x)
        {
            return 0;
        }

        public static float InBack(float x)
        {
            return 0;
        }

        public static float OutBack(float x)
        {
            return 0;
        }

        public static float InOutBack(float x)
        {
            return 0;
        }

        public static float InBounce(float x)
        {
            return 0;
        }

        public static float OutBounce(float x)
        {
            return 0;
        }

        public static float InOutBounce(float x)
        {
            return 0;
        }
    }
}