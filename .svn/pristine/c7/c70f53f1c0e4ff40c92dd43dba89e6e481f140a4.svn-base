let leftOriginal = 15;
let centerOriginal = 65;
let rightOriginal = 20;

function toggleLeft() {
	const left = document.getElementById('leftPanel');
	const center = document.getElementById('centerPanel');
	const right = document.getElementById('rightPanel');

	const isReduced = parseFloat(left.style.width || leftOriginal + '%') < leftOriginal;

	if (isReduced) {
		left.style.width = leftOriginal + '%';
		center.style.width = centerOriginal + '%';
		right.style.width = rightOriginal + '%';
	} else {
		left.style.width = (leftOriginal / 2) + '%';
		const extra = leftOriginal / 2;
		center.style.width = centerOriginal + extra / 2 + '%';
		right.style.width = rightOriginal + extra / 2 + '%';
	}
}

function toggleCenter() {
	const center = document.getElementById('centerPanel');
	const right = document.getElementById('rightPanel');
	const left = document.getElementById('leftPanel');
	const isReducedSource = parseFloat(left.style.width || leftOriginal + '%') < leftOriginal;
	const isReduced = parseFloat(center.style.width || centerOriginal + '%') < centerOriginal;

	if (isReduced) {
		center.style.width = centerOriginal + '%';
		right.style.width = rightOriginal + '%';
	} else {
		if (isReducedSource) {
			center.style.width = (centerOriginal / 2) + (leftOriginal / 2) + '%';
			right.style.width = rightOriginal + centerOriginal / 2 + (leftOriginal / 2) + '%';
		}
		else {
			center.style.width = (centerOriginal / 2) + '%';
			right.style.width = rightOriginal + centerOriginal / 2 + '%';
		}
	}
}

function toggleRight() {
	const center = document.getElementById('centerPanel');
	const right = document.getElementById('rightPanel');
	const left = document.getElementById('leftPanel');
	const isReducedSource = parseFloat(left.style.width || leftOriginal + '%') < leftOriginal;
	const isReduced = parseFloat(right.style.width || rightOriginal + '%') > rightOriginal;
	console.log(isReduced);
	if (isReduced) {
		center.style.width = centerOriginal + '%';
		right.style.width = isReducedSource ? (leftOriginal / 2) + rightOriginal + '%' : rightOriginal + '%';
	} else {
		if (isReducedSource) {
			center.style.width = (centerOriginal / 2) + (leftOriginal / 2) + '%';
			right.style.width = rightOriginal + centerOriginal / 2 + (leftOriginal / 2) + '%';
		}
		else {
			center.style.width = (centerOriginal / 2) + '%';
			right.style.width = rightOriginal + centerOriginal / 2 + '%';
		}
	}
	//right.style.width = isReduced ? rightOriginal + '%' : (rightOriginal / 2) + '%';
}

// Chatbot Part*/

// script.js
const chatInput =
	document.querySelector('.chat-input input');
const contextInput =
	document.querySelector('[id=\'majHTML\']');
const sendChatBtn =
	document.querySelector('.chat-input button');
const chatbox = document.querySelector(".chatbox");

let userMessage;
let ContextMessage;

const createChatLi = (message, className) => {
	const chatLi = document.createElement("li");
	chatLi.classList.add("chat", className);
	let chatContent =
		className === "chat-outgoing" ? `<p>${message}</p>` : `<p>${message}</p>`;
	chatLi.innerHTML = chatContent;
	return chatLi;
}
const generateResponse = (incomingChatLi) => {
	//SendSimplePrompt
	const messageElement = incomingChatLi.querySelector("p");
	$.ajax({
		type: "POST",
		url: "/Home/SendSimplePrompt",
		data: { prompteur: userMessage, context: ContextMessage },
		success: function (response) {
			messageElement.textContent = response;
		},
		failure: function (response) {
			//alert(response.responseText);
		},
		error: function (response) {
			//alert(response.responseText);
		}
	});
};


const handleChat = () => {
	userMessage = chatInput.value.trim();
	ContextMessage = contextInput.outerText.trim();
	if (!userMessage) {
		return;
	}
	chatbox
		.appendChild(createChatLi(userMessage, "chat-outgoing"));
	chatbox
		.scrollTo(0, chatbox.scrollHeight);

	setTimeout(() => {
		const incomingChatLi = createChatLi("Recherche...", "chat-incoming")
		chatbox.appendChild(incomingChatLi);
		chatbox.scrollTo(0, chatbox.scrollHeight);
		generateResponse(incomingChatLi);
	}, 600);
}

sendChatBtn.addEventListener("click", handleChat);

function cancel() {
	let chatbotcomplete = document.querySelector(".chatBot");
	if (chatbotcomplete.style.display != 'none') {
		chatbotcomplete.style.display = "none";
		let lastMsg = document.createElement("p");
		lastMsg.textContent = 'Thanks for using our Chatbot!';
		lastMsg.classList.add('lastMessage');
		document.body.appendChild(lastMsg)
	}
}