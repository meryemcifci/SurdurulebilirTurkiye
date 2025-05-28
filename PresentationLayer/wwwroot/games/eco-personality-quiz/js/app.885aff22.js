//(function(){"use strict";var t={7656:function(t,e,n){var r=n(5130),a=n(6768);const o={id:"app"};function s(t,e,n,r,s,i){return(0,a.uX)(),(0,a.CE)("div",o,[((0,a.uX)(),(0,a.Wv)((0,a.$y)(s.currentView),{shuffledQuestions:s.shuffledQuestions,onStartQuiz:i.startQuiz,onGoHome:i.goHome},null,40,["shuffledQuestions","onStartQuiz","onGoHome"]))])}const i={class:"home"};function u(t,e,n,r,o,s){return(0,a.uX)(),(0,a.CE)("div",i,[e[1]||(e[1]=(0,a.Lk)("h1",null,"Sürdürülebilir Yaşam Testi",-1)),(0,a.Lk)("button",{onClick:e[0]||(e[0]=e=>t.$emit("start-quiz"))},"Teste Başla")])}var l={name:"HomeView"},c=n(1241);const f=(0,c.A)(l,[["render",u],["__scopeId","data-v-66e71496"]]);var m=f,p=n(4232);const k={class:"quiz-container"},d={key:0,class:"question-card"},h={class:"options"},g=["onClick"],v={key:1,class:"result"},y={class:"result-details"},b={class:"emoji"},x=["src"];function Q(t,e,n,r,o,s){return(0,a.uX)(),(0,a.CE)("div",k,[o.currentQuestion<o.questions.length?((0,a.uX)(),(0,a.CE)("div",d,[(0,a.Lk)("h2",null,"Soru "+(0,p.v_)(o.currentQuestion+1),1),(0,a.Lk)("p",null,(0,p.v_)(o.questions[o.currentQuestion].question),1),(0,a.Lk)("div",h,[((0,a.uX)(!0),(0,a.CE)(a.FK,null,(0,a.pI)(o.questions[o.currentQuestion].options,((t,e)=>((0,a.uX)(),(0,a.CE)("button",{key:e,onClick:e=>s.selectOption(t.score)},(0,p.v_)(t.text),9,g)))),128))])])):((0,a.uX)(),(0,a.CE)("div",v,[e[1]||(e[1]=(0,a.Lk)("h2",null,"Test Bitti",-1)),(0,a.Lk)("p",null,"Toplam Puan: "+(0,p.v_)(o.totalScore),1),(0,a.Lk)("div",y,[(0,a.Lk)("div",b,[(0,a.eW)((0,p.v_)(s.resultData.emoji)+" ",1),(0,a.Lk)("img",{src:s.resultData.image,alt:"Karakter Görseli",class:"result-image"},null,8,x)]),(0,a.Lk)("h3",null,(0,p.v_)(s.resultData.title),1),(0,a.Lk)("p",null,(0,p.v_)(s.resultData.message),1),(0,a.Lk)("ul",null,[((0,a.uX)(!0),(0,a.CE)(a.FK,null,(0,a.pI)(s.resultData.suggestions,((t,e)=>((0,a.uX)(),(0,a.CE)("li",{key:e}," ✔️ "+(0,p.v_)(t),1)))),128))])]),(0,a.Lk)("button",{onClick:e[0]||(e[0]=e=>t.$emit("go-home"))},"Ana Sayfaya Dön")]))])}var z={name:"QuizPage",props:["shuffledQuestions"],data(){return{questions:this.shuffledQuestions,currentQuestion:0,totalScore:0}},methods:{selectOption(t){this.totalScore+=t,this.currentQuestion++}},computed:{resultData(){return this.totalScore<=4?{title:"Doğa Dostu",message:"Yaşantın oldukça sürdürülebilir! Tebrikler!",image:"https://cdn-icons-png.flaticon.com/512/1995/1995574.png",suggestions:["Bu alışkanlıklarını arkadaşlarına da anlat.","Kullandığın ürünlerin etiketlerine dikkat et.","Enerji tasarrufunu sürdür!"]}:this.totalScore<=9?{title:"Gelişime Açık",message:"Fena değil ama daha sürdürülebilir seçimler yapabilirsin.",image:"https://cdn-icons-png.flaticon.com/512/3381/3381627.png",suggestions:["Bez çanta taşımayı alışkanlık haline getir.","Muslukları açık bırakma.","Çevre dostu temizlik ürünleri kullanmayı dene."]}:{title:"Dikkat!",message:"Daha çevreci seçimler yapmalısın. Doğa seni bekliyor!",image:"https://cdn-icons-png.flaticon.com/512/679/679922.png",suggestions:["Plastik poşet kullanımını azalt.","Kısa duşlar alarak su tasarrufu yap.","Geri dönüşüm kutularını kullanmaya başla."]}}}};const _=(0,c.A)(z,[["render",Q],["__scopeId","data-v-0108cbb8"]]);var q=_;const w=[{question:"Haftada kaç gün araba kullanıyorsun?",options:[{text:"0-1 gün",score:0},{text:"2-4 gün",score:2},{text:"5+ gün",score:4}]},{question:"Genellikle ne tür çanta kullanırsın?",options:[{text:"Bez çanta",score:0},{text:"Kağıt poşet",score:1},{text:"Plastik poşet",score:3}]},{question:"Suyu ne sıklıkla boşa akıtırsın?",options:[{text:"Asla",score:0},{text:"Ara sıra",score:2},{text:"Çoğu zaman",score:4}]},{question:"Atıkları nasıl ayırırsın?",options:[{text:"Geri dönüşüm kutularına göre ayırırım",score:0},{text:"Bazen ayırırım",score:2},{text:"Hiç ayırmam",score:4}]},{question:"Genellikle nasıl ulaşım sağlarsın?",options:[{text:"Yürürüm / bisiklet",score:0},{text:"Toplu taşıma",score:1},{text:"Özel araç",score:3}]},{question:"Enerji tasarrufu için hangi yöntemleri uyguluyorsunuz?",options:[{text:"Enerji tasarruflu ampul",score:1},{text:"Flüoresan ampul",score:2},{text:"Klasik ampul",score:3}]}];var C={name:"App",components:{HomeView:m,QuizPage:q},data(){return{currentView:"HomeView",shuffledQuestions:[]}},methods:{startQuiz(){this.shuffledQuestions=this.shuffleArray(w),this.currentView="QuizPage"},goHome(){this.currentView="HomeView"},shuffleArray(t){const e=[...t];for(let n=e.length-1;n>0;n--){const t=Math.floor(Math.random()*(n+1));[e[n],e[t]]=[e[t],e[n]]}return e}}};const E=(0,c.A)(C,[["render",s]]);var L=E;(0,r.Ef)(L).mount("#app")}},e={};function n(r){var a=e[r];if(void 0!==a)return a.exports;var o=e[r]={exports:{}};return t[r].call(o.exports,o,o.exports,n),o.exports}n.m=t,function(){var t=[];n.O=function(e,r,a,o){if(!r){var s=1/0;for(c=0;c<t.length;c++){r=t[c][0],a=t[c][1],o=t[c][2];for(var i=!0,u=0;u<r.length;u++)(!1&o||s>=o)&&Object.keys(n.O).every((function(t){return n.O[t](r[u])}))?r.splice(u--,1):(i=!1,o<s&&(s=o));if(i){t.splice(c--,1);var l=a();void 0!==l&&(e=l)}}return e}o=o||0;for(var c=t.length;c>0&&t[c-1][2]>o;c--)t[c]=t[c-1];t[c]=[r,a,o]}}(),function(){n.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return n.d(e,{a:e}),e}}(),function(){n.d=function(t,e){for(var r in e)n.o(e,r)&&!n.o(t,r)&&Object.defineProperty(t,r,{enumerable:!0,get:e[r]})}}(),function(){n.g=function(){if("object"===typeof globalThis)return globalThis;try{return this||new Function("return this")()}catch(t){if("object"===typeof window)return window}}()}(),function(){n.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)}}(),function(){var t={524:0};n.O.j=function(e){return 0===t[e]};var e=function(e,r){var a,o,s=r[0],i=r[1],u=r[2],l=0;if(s.some((function(e){return 0!==t[e]}))){for(a in i)n.o(i,a)&&(n.m[a]=i[a]);if(u)var c=u(n)}for(e&&e(r);l<s.length;l++)o=s[l],n.o(t,o)&&t[o]&&t[o][0](),t[o]=0;return n.O(c)},r=self["webpackChunkeco_personality_quiz"]=self["webpackChunkeco_personality_quiz"]||[];r.forEach(e.bind(null,0)),r.push=e.bind(null,r.push.bind(r))}();var r=n.O(void 0,[504],(function(){return n(7656)}));r=n.O(r)})();
////# sourceMappingURL=app.885aff22.js.map


const app = document.getElementById("app");

const questions = [
    { question: "Haftada kaç gün araba kullanıyorsun?", options: [{ text: "0-1 gün", score: 0 }, { text: "2-4 gün", score: 2 }, { text: "5+ gün", score: 4 }] },
    { question: "Genellikle ne tür çanta kullanırsın?", options: [{ text: "Bez çanta", score: 0 }, { text: "Kağıt poşet", score: 1 }, { text: "Plastik poşet", score: 3 }] },
    { question: "Suyu ne sıklıkla boşa akıtırsın?", options: [{ text: "Asla", score: 0 }, { text: "Ara sıra", score: 2 }, { text: "Çoğu zaman", score: 4 }] },
    { question: "Atıkları nasıl ayırırsın?", options: [{ text: "Geri dönüşüm kutularına göre ayırırım", score: 0 }, { text: "Bazen ayırırım", score: 2 }, { text: "Hiç ayırmam", score: 4 }] },
    { question: "Genellikle nasıl ulaşım sağlarsın?", options: [{ text: "Yürürüm / bisiklet", score: 0 }, { text: "Toplu taşıma", score: 1 }, { text: "Özel araç", score: 3 }] },
    { question: "Enerji tasarrufu için hangi yöntemleri uyguluyorsunuz?", options: [{ text: "Enerji tasarruflu ampul", score: 1 }, { text: "Flüoresan ampul", score: 2 }, { text: "Klasik ampul", score: 3 }] },
];

let shuffledQuestions = [];
let currentQuestion = 0;
let totalScore = 0;

function shuffleArray(array) {
    const copy = [...array];
    for (let i = copy.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [copy[i], copy[j]] = [copy[j], copy[i]];
    }
    return copy;
}

function showHome() {
    app.innerHTML = `
      <div class="home">
        <h1>Sürdürülebilir Yaşam Testi</h1>
        <button id="startBtn">Teste Başla</button>
      </div>
    `;
}
function startQuiz() {
    document.getElementById('intro').classList.add('hidden');
    document.getElementById('game').classList.remove('hidden');
    shuffledQuestions = shuffleArray(questions);
    currentQuestion = 0;
    totalScore = 0;
    showQuestion();
}

function showQuestion() {
    if (currentQuestion >= shuffledQuestions.length) {
        showResult();
        return;
    }
    const q = shuffledQuestions[currentQuestion];
    let optionsHtml = q.options.map((opt, idx) =>
        `<button data-score="${opt.score}">${opt.text}</button>`
    ).join("");
    app.innerHTML = `
      <div class="question-card">
        <h2>Soru ${currentQuestion + 1}</h2>
        <p>${q.question}</p>
        <div class="options">${optionsHtml}</div>
      </div>
    `;
    document.querySelectorAll(".options button").forEach(btn => {
        btn.addEventListener("click", () => {
            totalScore += parseInt(btn.getAttribute("data-score"));
            currentQuestion++;
            showQuestion();
        });
    });

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
    let resultData;
    if (totalScore <= 4) {
        resultData = {
            title: "Doğa Dostu",
            message: "Yaşantın oldukça sürdürülebilir! Tebrikler!",
            image: "https://cdn-icons-png.flaticon.com/512/1995/1995574.png",
            suggestions: ["Bu alışkanlıklarını arkadaşlarına da anlat.", "Kullandığın ürünlerin etiketlerine dikkat et.", "Enerji tasarrufunu sürdür!"]
        };
    } else if (totalScore <= 9) {
        resultData = {
            title: "Gelişime Açık",
            message: "Fena değil ama daha sürdürülebilir seçimler yapabilirsin.",
            image: "https://cdn-icons-png.flaticon.com/512/3381/3381627.png",
            suggestions: ["Bez çanta taşımayı alışkanlık haline getir.", "Muslukları açık bırakma.", "Çevre dostu temizlik ürünleri kullanmayı dene."]
        };
    } else {
        resultData = {
            title: "Dikkat!",
            message: "Daha çevreci seçimler yapmalısın. Doğa seni bekliyor!",
            image: "https://cdn-icons-png.flaticon.com/512/679/679922.png",
            suggestions: ["Plastik poşet kullanımını azalt.", "Kısa duşlar alarak su tasarrufu yap.", "Geri dönüşüm kutularını kullanmaya başla."]
        };
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
            }
        }, 300);
    }