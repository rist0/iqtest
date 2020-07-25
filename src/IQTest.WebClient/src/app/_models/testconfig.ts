export class ITestConfig {
    numberOfQuestions: number;
    allowBack: boolean;
    allowReview: boolean;
    autoMove: boolean;  // move to next question automatically when answering
    duration: number;  // max time allowed. 0 = unlimited.
    requiredAll: boolean;
    shuffleQuestions: boolean;
    shuffleOptions: boolean;
    showClock: boolean;
    showPager: boolean;
}