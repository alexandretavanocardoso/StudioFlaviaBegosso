<template>
    <div class="mg-top">
        <div class="flex row">
            <div class="col-md-4" v-for="(contact, index) in contacts" :key="index">
                <div class="card">
                    <div class="card-body">
                        <i :class="`${contact.icon} icon`"
                            :style="`color: ${contact.colorIcon}; border: 3px solid ${contact.colorIcon};`"></i>
                        <h5 class="card-title">{{ contact.name }}</h5>
                        <a :href="contact.link" class="linkContact" target="_blank">{{ contact.linkContent }}</a>
                    </div>
                </div>
            </div>
            <iframe
                src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d29533.707475838935!2d-48.56122778171823!3d-22.28884255646692!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94b8a7b1fae8546d%3A0x89195cbaf3ed2553!2sStudio%20Flavia%20Begosso%20-%20Extens%C3%A3o%20de%20C%C3%ADlios%20-%20Ja%C3%BA!5e0!3m2!1spt-BR!2sbr!4v1670027907814!5m2!1spt-BR!2sbr"
                referrerpolicy="no-referrer-when-downgrade"></iframe>
        </div>
    </div>
</template>

<script>
export default {
    name: 'ContactComponent',
    data: () => ({
        contacts: [
            {
                icon: "bi bi-instagram",
                colorIcon: "#125688",
                name: "Instagram",
                link: "https://www.instagram.com/studioflaviabegosso/",
                linkContent: "@studioflaviabegosso"
            },
            {
                icon: "bi bi-facebook",
                colorIcon: "#2374e1",
                name: "Facebook",
                link: "https://www.facebook.com/StudioFlaviaBegosso",
                linkContent: "studioflaviabegosso"
            },
            {
                icon: "bi bi-whatsapp",
                colorIcon: "#25d366",
                name: "WhatsApp",
                link: "https://web.whatsapp.com/send?phone=5514998749060&text=Bom%20dia!",
                linkContent: "(14) 99172-9539"
            }
        ]
    })
}
</script>


<style src="./Contact.scss" lang="scss" scoped>

</style>