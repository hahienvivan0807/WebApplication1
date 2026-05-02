async function DangNhap() {
    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;

    console.log(username);
    console.log(password);

    const duLieu = {
        Username: username,
        Password: password
    }
    const response = await fetch("/api/simple/dangnhap", {
        method: "POST",
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(duLieu)
    });
    try {
        if (response.ok) {
            alert("Đăng nhập thành công");
        } else {
            alert("Đăng nhập thất bại");
        }
    } catch (error) {
        console.error("Khong kết nối được")
    }
}