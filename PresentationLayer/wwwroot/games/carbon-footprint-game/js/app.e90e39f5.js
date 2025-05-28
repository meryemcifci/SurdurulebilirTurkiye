
const questions = [
{
    question: "Bugün okula/işe nasıl gittin?",
options: [
{text: "🚶 Yürüyerek", score: 5 },
{text: "🚌 Toplu taşıma", score: 3 },
{text: "🚗 Özel araç", score: 0 }
]
        },
{
    question: "Bugün ana öğününde ne yedin?",
options: [
{text: "🥩 Et yemeği", score: 1 },
{text: "🥗 Sebze yemeği", score: 5 },
{text: "🍕 Hazır yemek", score: 2 }
]
        },
{
    question: "Evde ışıkları söndürmeyi unutuyor musun?",
options: [
{text: "😔 Sık sık unutuyorum", score: 0 },
{text: "🤔 Bazen unutuyorum", score: 2 },
{text: "😊 Hep söndürüyorum", score: 5 }
]
        },
{
    question: "Geri dönüşüm yapıyor musun?",
options: [
{text: "♻️ Düzenli yapıyorum", score: 5 },
{text: "🤷 Arada yapıyorum", score: 2 },
{text: "❌ Yapmıyorum", score: 0 }
]
        },
{
    question: "Su kullanımında nasıl davranıyorsun?",
options: [
{text: "💧 Çok dikkatli kullanıyorum", score: 5 },
{text: "💦 Orta düzeyde dikkatli", score: 3 },
{text: "🚿 Pek dikkat etmiyorum", score: 0 }
]
        }
];

let currentQuestion = 0;
let totalScore = 0;
let maxScore = 25;

function startGame() {
    document.getElementById('intro').classList.add('hidden');
    document.getElementById('game').classList.remove('hidden');
    currentQuestion = 0;
    totalScore = 0;
    showQuestion();
}


function showQuestion() {
    if (currentQuestion >= questions.length) {
        showResult();
        return;
    }

    const question = questions[currentQuestion];
    document.getElementById('questionText').textContent = question.question;

    const optionsDiv = document.getElementById('options');
    optionsDiv.innerHTML = '';
            
    question.options.forEach(option => {
        const button = document.createElement('button');
        button.textContent = option.text;
        button.onclick = () => selectAnswer(option.score);
    optionsDiv.appendChild(button);
    });
}

function selectAnswer(score) {
    totalScore += score;
    currentQuestion++;
    showQuestion();
}

function showResult() {
    document.getElementById('game').classList.add('hidden');
    document.getElementById('result').classList.remove('hidden');

    const percentage = Math.round((totalScore / maxScore) * 100);
    document.getElementById('finalScore').textContent = `${totalScore} / ${maxScore} Puan`;

    const progressBar = document.getElementById('progressBar');
    progressBar.style.width = percentage + '%';

let message, color;
    if (percentage >= 80) {
        message = "🌟 Harika! Çevre dostu bir yaşam sürüyorsunuz!";
        color = "#4CAF50";
    } else if (percentage >= 60) {
        message = "👍 İyi! Biraz daha dikkat ederseniz mükemmel olur!";
        color = "#FFC107";
    } else {
        message = "🌍 Çevre için daha fazla çaba göstermelisiniz!";
        color = "#F44336";
    }        

    progressBar.style.backgroundColor = color;
    const feedbackDiv = document.getElementById('feedback');
    feedbackDiv.textContent = message;
    feedbackDiv.style.backgroundColor = color + '20';
    feedbackDiv.style.color = color;
}

function restartGame() {
    document.getElementById('result').classList.add('hidden');
document.getElementById('intro').classList.remove('hidden');
}
function NewGame() {
    document.body.style.opacity = '0';
    setTimeout(() => {
        Swal.fire({
            title: 'Emin misiniz?',
            text: "Oyunlar sayfasına dönmek istediğinizden emin misiniz?",
            icon: 'question',
            showCancelButton: true,
            confirmButtonText: 'Evet, dön!',
            cancelButtonText: 'İptal'
        }).then((result) => {
            if (result.isConfirmed) {
                window.location.href = '/Game/Index';
            } else {
                document.body.style.opacity = '1'; // İptal edilirse ekranı geri getir.....
            }
        });
    }, 300); //gecikme süresi
}