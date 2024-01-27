using System.Collections.Generic;
using UnityEngine;
namespace Deobfuscated
{
    internal class GrabDetector : MonoBehaviour
    {


        private void POJMONJMBLF(Rigidbody HIDKKCLJLEE)
        {
            this.PJKHGEKNJHI.Clear();
            int num = Physics.OverlapSphereNonAlloc(this.FNGNILGGNEG.MultiplyPoint3x4(this.BOJOPFDPGLD), 1.4f, this.EFBPOKEMIFH);
            for (int i = 0; i < num; i++)
            {
                if (!(this.EFBPOKEMIFH[i].attachedRigidbody == null) && !this.EFBPOKEMIFH[i].attachedRigidbody.isKinematic)
                {
                    Rigidbody attachedRigidbody = this.EFBPOKEMIFH[i].attachedRigidbody;
                    if (HIDKKCLJLEE == attachedRigidbody || BFNMKMBJKJO.POMKGJDAIBO(HIDKKCLJLEE, attachedRigidbody) || OFLJNAJKDHM.NMNBLMIPPID(HIDKKCLJLEE, attachedRigidbody))
                    {
                        this.PJKHGEKNJHI.Add(this.EFBPOKEMIFH[i]);
                    }
                    else if (attachedRigidbody.gameObject.layer == 8 && HIDKKCLJLEE.gameObject.layer == 8 && HIDKKCLJLEE.transform.parent == attachedRigidbody.transform.parent)
                    {
                        this.PJKHGEKNJHI.Add(this.EFBPOKEMIFH[i]);
                    }
                }
            }
        }






        private bool DIFHAJBFOKM(ref Vector3 JBMCGAGGDPP, out float KLHOINJMEGL, bool EBLNLDELEPD)
        {
            KLHOINJMEGL = Vector3.Distance(this.JOBKCJMOJIF, JBMCGAGGDPP);
            if (KLHOINJMEGL > 1f || JBMCGAGGDPP.x < 0f || JBMCGAGGDPP.y > 0.25f || JBMCGAGGDPP.z > 0.85f)
            {
                return false;
            }
            if (EBLNLDELEPD)
            {
                this.LCLEGNOCOGI = this.HLLBGJMNLLE.MultiplyPoint3x4(this.FNGNILGGNEG.MultiplyPoint3x4(JBMCGAGGDPP));
                if (this.LCLEGNOCOGI.z < -0.2f)
                {
                    return false;
                }
            }
            if (KLHOINJMEGL < 0.25f)
            {
                JBMCGAGGDPP = this.JOBKCJMOJIF + (JBMCGAGGDPP - this.JOBKCJMOJIF).normalized * 0.25f;
            }
            return true;
        }




        private void AJBICBHHKBC(ref Weapon HGHMHAJAFOG)
        {
            if (this.OLAKOHNAKOA.Count == 0)
            {
                return;
            }
            this.availableWeapons.Clear();
            this.NNMMDJDMJDB.Clear();
            Vector3 vector = this.FNGNILGGNEG.MultiplyPoint3x4(this.AFNBAACGAIL);
            float num;
            foreach (Weapon weapon in this.OLAKOHNAKOA)
            {
                Vector3 position = weapon.grabPositions[0].position;
                if (Physics.Raycast(vector, position - vector, out this.AAOHBCGPIEG) && !(this.AAOHBCGPIEG.collider.transform != weapon.transform))
                {
                    num = Vector3.Distance(position, this.GKFDGDBHABK);
                    if (num <= 1.3f && num >= 0.3f)
                    {
                        Vector3 vector2 = this.HLLBGJMNLLE.MultiplyPoint3x4(position);
                        if (vector2.y <= -0.05f && Mathf.Abs(vector2.x) <= 1f)
                        {
                            this.availableWeapons.Add(weapon);
                            this.NNMMDJDMJDB.Add(num);
                        }
                    }
                }
            }
            if (this.availableWeapons.Count == 0)
            {
                return;
            }
            num = float.MaxValue;
            for (int i = 0; i < this.availableWeapons.Count; i++)
            {
                if (num > this.NNMMDJDMJDB[i])
                {
                    num = this.NNMMDJDMJDB[i];
                    HGHMHAJAFOG = this.availableWeapons[i];
                }
            }
        }




        private void CKICBGGEFCK(bool EBLNLDELEPD)
        {
            this.MDJEKCGMJCJ.Clear();
            this.OMBAPHAINDA.Clear();
            foreach (Vector3 item in this.MJILAGEIOOG)
            {
                float item2;
                //if (this.GHKEKBIHGJB(ref item, out item2, EBLNLDELEPD))
                //{
                this.MDJEKCGMJCJ.Add(item);
                //this.OMBAPHAINDA.Add(item2);
                //}
            }
        }


        private void DKKOPICBHPC()
        {
            this.BPABADEEJEA.Clear();
            this.OLAKOHNAKOA.Clear();
            int num = Physics.OverlapSphereNonAlloc(this.FNGNILGGNEG.MultiplyPoint3x4(this.BOJOPFDPGLD), 1.4f, this.EFBPOKEMIFH);
            for (int i = 0; i < num; i++)
            {
                GameObject gameObject = this.EFBPOKEMIFH[i].gameObject;
                if (PhysicsIgnoredList.NoGrabObjects == null || !PhysicsIgnoredList.NoGrabObjects.Contains(gameObject))
                {
                    Rigidbody attachedRigidbody = this.EFBPOKEMIFH[i].attachedRigidbody;
                    if (!this.ADICJILOOEJ.Contains(gameObject) && attachedRigidbody != null && !attachedRigidbody.isKinematic && !PADJPIDNGPI.CAHGLANGCEN.Contains(attachedRigidbody))
                    {
                        if (this.EFBPOKEMIFH[i] is MeshCollider)
                        {
                            if (((MeshCollider)this.EFBPOKEMIFH[i]).convex)
                            {
                                this.BPABADEEJEA.Add(this.EFBPOKEMIFH[i]);
                            }
                        }
                        else
                        {
                            this.BPABADEEJEA.Add(this.EFBPOKEMIFH[i]);
                        }
                    }
                    if (gameObject.layer == 10 && GameObjectToWeaponMapper.gameObjectToWeaponMap.ContainsKey(gameObject))
                    {
                        Weapon weapon = GameObjectToWeaponMapper.gameObjectToWeaponMap[gameObject];
                        if (!(weapon.Owner != null))
                        {
                            this.OLAKOHNAKOA.Add(weapon);
                        }
                    }
                }
            }
        }



        private void NKNJOCHBAJF()
        {
            this.CMENBABHHPE = this.ELDPMCGDHKJ.position;
            this.AMMKFHEIOMJ = this.ELDPMCGDHKJ.forward;
            this.LCHFJIBGAPI = this.ELDPMCGDHKJ.up;
            this.OKCFILGLIDO = this.ELDPMCGDHKJ.right;
            this.FNGNILGGNEG = this.ELDPMCGDHKJ.localToWorldMatrix;
            this.OKBILNNGDJK = this.ELDPMCGDHKJ.worldToLocalMatrix;
            this.GKFDGDBHABK = this.EIJAPLDDFEM.position;
            this.HCEIKHOPMDK = this.EIJAPLDDFEM.up;
            this.HLLBGJMNLLE = this.EIJAPLDDFEM.worldToLocalMatrix;
            this.JIHCDBGNLED = this.GHKDFNOINDC.localToWorldMatrix;
            this.NDGFOKBLIEN = this.GHKDFNOINDC.worldToLocalMatrix;
        }

        internal void LMIHMJILEBP(bool GFOMLIJNMOM, Rigidbody MAMCAKHFIAO, bool PFADDNNINMM)
        {
            this.NKNJOCHBAJF();
            this.AMGIBPCJAMN = false;
            if (PFADDNNINMM)
            {
                this.HAGNDOLLHGD();
                this.KCMLEDHLJDO();
                this.AMGIBPCJAMN = (this.MDJEKCGMJCJ.Count > 0);
                if (this.AMGIBPCJAMN)
                {
                    this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.MDJEKCGMJCJ, this.OMBAPHAINDA);
                    return;
                }
            }
            else if (GFOMLIJNMOM || (MAMCAKHFIAO != null && MAMCAKHFIAO.isKinematic))
            {
                this.MKHNPAOLAGN(false);
                this.CKICBGGEFCK(true);
                this.AMGIBPCJAMN = (this.MDJEKCGMJCJ.Count > 0);
                if (this.AMGIBPCJAMN)
                {
                    this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.MDJEKCGMJCJ, this.OMBAPHAINDA);
                    return;
                }
            }
            else
            {
                this.POJMONJMBLF(MAMCAKHFIAO);
                this.MOLJGFHCKEK(this.PJKHGEKNJHI);
                this.AMGIBPCJAMN = (this.KMFEGINMMEI.Count > 0);
                if (this.AMGIBPCJAMN)
                {
                    this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.KMFEGINMMEI, this.IDDEJJNOODP);
                }
            }
        }



        internal void AIOKPBPGIBI(bool GFOMLIJNMOM, Rigidbody MAMCAKHFIAO, bool PFADDNNINMM)
        {
            this.NKNJOCHBAJF();
            this.IKLPPDPJFJC = false;
            if (PFADDNNINMM)
            {
                this.HAGNDOLLHGD();
                this.HDHEOHFGIOD();
                this.IKLPPDPJFJC = (this.APNNJKDDNMG.Count > 0);
                if (this.IKLPPDPJFJC)
                {
                    this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.APNNJKDDNMG, this.MLIPKFPLDLJ);
                    return;
                }
            }
            else if (GFOMLIJNMOM || (MAMCAKHFIAO != null && MAMCAKHFIAO.isKinematic))
            {
                this.MKHNPAOLAGN(false);
                this.NMGAENPIFMB(true);
                this.IKLPPDPJFJC = (this.APNNJKDDNMG.Count > 0);
                if (this.IKLPPDPJFJC)
                {
                    this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.APNNJKDDNMG, this.MLIPKFPLDLJ);
                    return;
                }
            }
            else
            {
                this.POJMONJMBLF(MAMCAKHFIAO);
                this.AGAHLKICAFH(this.PJKHGEKNJHI);
                this.IKLPPDPJFJC = (this.KMMHNLLOFEJ.Count > 0);
                if (this.IKLPPDPJFJC)
                {
                    this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.KMMHNLLOFEJ, this.AOCEHKOAIPE);
                }
            }
        }


        private bool GHKEKBIHGJB(ref Vector3 JBMCGAGGDPP, out float KLHOINJMEGL, bool EBLNLDELEPD)
        {
            KLHOINJMEGL = Vector3.Distance(this.PAMPMLOLDGM, JBMCGAGGDPP);
            if (KLHOINJMEGL > 1f || JBMCGAGGDPP.x > 0f || JBMCGAGGDPP.y > 0.25f || JBMCGAGGDPP.z > 0.85f)
            {
                return false;
            }
            if (EBLNLDELEPD)
            {
                this.LCLEGNOCOGI = this.HLLBGJMNLLE.MultiplyPoint3x4(this.FNGNILGGNEG.MultiplyPoint3x4(JBMCGAGGDPP));
                if (this.LCLEGNOCOGI.z < -0.2f)
                {
                    return false;
                }
            }
            if (KLHOINJMEGL < 0.25f)
            {
                JBMCGAGGDPP = this.PAMPMLOLDGM + (JBMCGAGGDPP - this.PAMPMLOLDGM).normalized * 0.25f;
            }
            return true;
        }


        private void PDGAACODOIM(RaycastHit[] KIIPOLDCOCC, int DLOLBMKJEOH)
        {
            for (int i = 0; i < DLOLBMKJEOH; i++)
            {
                GameObject gameObject = KIIPOLDCOCC[i].collider.gameObject;
                if ((PhysicsIgnoredList.NoGrabObjects == null || !PhysicsIgnoredList.NoGrabObjects.Contains(gameObject)) && (!(KIIPOLDCOCC[i].rigidbody != null) || KIIPOLDCOCC[i].rigidbody.isKinematic) && !this.ADICJILOOEJ.Contains(gameObject))
                {
                    this.MJILAGEIOOG.Add(this.OKBILNNGDJK.MultiplyPoint3x4(KIIPOLDCOCC[i].point));
                }
            }
        }


        private void KCMLEDHLJDO()
        {
            this.MDJEKCGMJCJ.Clear();
            this.OMBAPHAINDA.Clear();
            foreach (Vector3 item in this.MJILAGEIOOG)
            {
                float item2;
                //if (this.PPIFOKEOFGN(ref item, out item2))
                //{
                this.MDJEKCGMJCJ.Add(item);
                //this.OMBAPHAINDA.Add(item2);
                //}
            }
        }


        private void MOLJGFHCKEK(HashSet<Collider> PJFHMFKHHEI)
        {
            this.KMFEGINMMEI.Clear();
            this.IDDEJJNOODP.Clear();
            Vector3 position = this.ELDPMCGDHKJ.localToWorldMatrix.MultiplyPoint3x4(this.PAMPMLOLDGM);
            foreach (Collider collider in PJFHMFKHHEI)
            {
                Vector3 point = collider.ClosestPoint(position);
                Vector3 item = this.OKBILNNGDJK.MultiplyPoint3x4(point);
                float item2;
                if (this.GHKEKBIHGJB(ref item, out item2, false))
                {
                    this.KMFEGINMMEI.Add(item);
                    this.IDDEJJNOODP.Add(item2);
                }
            }
        }



        private Vector3 DHLHMBOGAKE(List<Vector3> FFANACPBJEI, List<float> FMJKKNILMKI)
        {
            float num = float.MaxValue;
            int index = 0;
            for (int i = 0; i < FMJKKNILMKI.Count; i++)
            {
                if (FMJKKNILMKI[i] < num)
                {
                    num = FMJKKNILMKI[i];
                    index = i;
                }
            }
            return FFANACPBJEI[index];
        }


        private void DONMHGOAEGC(RaycastHit[] KIIPOLDCOCC, int DLOLBMKJEOH)
        {
            for (int i = 0; i < DLOLBMKJEOH; i++)
            {
                GameObject gameObject = KIIPOLDCOCC[i].collider.gameObject;
                if ((PhysicsIgnoredList.NoGrabObjects == null || !PhysicsIgnoredList.NoGrabObjects.Contains(gameObject)) && !this.ADICJILOOEJ.Contains(gameObject))
                {
                    this.MJILAGEIOOG.Add(this.OKBILNNGDJK.MultiplyPoint3x4(KIIPOLDCOCC[i].point));
                }
            }
        }

        private void HDHEOHFGIOD()
        {
            this.APNNJKDDNMG.Clear();
            this.MLIPKFPLDLJ.Clear();
            foreach (Vector3 item in this.MJILAGEIOOG)
            {
                float item2;
                //if (this.DFPJDAGOGBP(ref item, out item2))
                //{
                this.APNNJKDDNMG.Add(item);
                //this.MLIPKFPLDLJ.Add(item2);
                //}
            }
        }


        internal void EAAKPIIBAIL(bool PFADDNNINMM)
        {
            if (FixedUpdateCounter.frameCount % 3 != this.NHFOBDMPPBC)
            {
                return;
            }
            this.NKNJOCHBAJF();
            this.AMGIBPCJAMN = false;
            this.IKLPPDPJFJC = false;
            this.LKIEHLMCJCM = null;
            if (PFADDNNINMM)
            {
                this.HAGNDOLLHGD();
                this.KCMLEDHLJDO();
                this.HDHEOHFGIOD();
                this.AMGIBPCJAMN = (this.MDJEKCGMJCJ.Count > 0);
                this.IKLPPDPJFJC = (this.APNNJKDDNMG.Count > 0);
                if (this.AMGIBPCJAMN)
                {
                    this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.MDJEKCGMJCJ, this.OMBAPHAINDA);
                }
                if (this.IKLPPDPJFJC)
                {
                    this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.APNNJKDDNMG, this.MLIPKFPLDLJ);
                    return;
                }
            }
            else if (this.KPLKMDDKCML.GDJNMJBCMMB || !this.KPLKMDDKCML.MJAFJDDBMHN)
            {
                this.MKHNPAOLAGN(true);
                this.CKICBGGEFCK(false);
                this.NMGAENPIFMB(false);
                this.AMGIBPCJAMN = (this.MDJEKCGMJCJ.Count > 0);
                this.IKLPPDPJFJC = (this.APNNJKDDNMG.Count > 0);
                if (this.AMGIBPCJAMN)
                {
                    this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.MDJEKCGMJCJ, this.OMBAPHAINDA);
                }
                if (this.IKLPPDPJFJC)
                {
                    this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.APNNJKDDNMG, this.MLIPKFPLDLJ);
                    return;
                }
            }
            else
            {
                this.DKKOPICBHPC();
                if (this.BPABADEEJEA.Count > 0)
                {
                    this.AJBICBHHKBC(ref this.LKIEHLMCJCM);
                    this.MOLJGFHCKEK(this.BPABADEEJEA);
                    this.AGAHLKICAFH(this.BPABADEEJEA);
                    this.AMGIBPCJAMN = (this.KMFEGINMMEI.Count > 0);
                    this.IKLPPDPJFJC = (this.KMMHNLLOFEJ.Count > 0);
                    if (this.AMGIBPCJAMN)
                    {
                        this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.KMFEGINMMEI, this.IDDEJJNOODP);
                    }
                    if (this.IKLPPDPJFJC)
                    {
                        this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.KMMHNLLOFEJ, this.AOCEHKOAIPE);
                    }
                    if (!this.AMGIBPCJAMN && !this.IKLPPDPJFJC)
                    {
                        this.MKHNPAOLAGN(true);
                        this.CKICBGGEFCK(true);
                        this.NMGAENPIFMB(true);
                        this.AMGIBPCJAMN = (this.MDJEKCGMJCJ.Count > 0);
                        this.IKLPPDPJFJC = (this.APNNJKDDNMG.Count > 0);
                        if (this.AMGIBPCJAMN)
                        {
                            this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.MDJEKCGMJCJ, this.OMBAPHAINDA);
                        }
                        if (this.IKLPPDPJFJC)
                        {
                            this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.APNNJKDDNMG, this.MLIPKFPLDLJ);
                            return;
                        }
                    }
                }
                else
                {
                    this.MKHNPAOLAGN(true);
                    this.CKICBGGEFCK(true);
                    this.NMGAENPIFMB(true);
                    this.AMGIBPCJAMN = (this.MDJEKCGMJCJ.Count > 0);
                    this.IKLPPDPJFJC = (this.APNNJKDDNMG.Count > 0);
                    if (this.AMGIBPCJAMN)
                    {
                        this.LCAFMAOFKAM = this.DHLHMBOGAKE(this.MDJEKCGMJCJ, this.OMBAPHAINDA);
                    }
                    if (this.IKLPPDPJFJC)
                    {
                        this.NOIJNEBKNOO = this.DHLHMBOGAKE(this.APNNJKDDNMG, this.MLIPKFPLDLJ);
                    }
                }
            }
        }


        private void MKHNPAOLAGN(bool HFBFDKCOIIP)
        {
            this.LCCEIHGAGFA = Physics.SphereCastNonAlloc(this.CMENBABHHPE - this.AMMKFHEIOMJ * 2.8f, 1.4f, this.AMMKFHEIOMJ, this.HKKECNGDFGK, 2.8f);
            this.HGINJNBCOGL = Physics.SphereCastNonAlloc(this.CMENBABHHPE + this.AMMKFHEIOMJ * 2.8f, 1.4f, -this.AMMKFHEIOMJ, this.MPMGKOBOIEL, 2.8f);
            this.BMAGNDKGPJH = Physics.SphereCastNonAlloc(this.CMENBABHHPE - this.OKCFILGLIDO * 2.8f, 1.4f, this.OKCFILGLIDO, this.GJJOGGNEILP, 2.8f);
            this.OKFFHPMALOP = Physics.SphereCastNonAlloc(this.CMENBABHHPE + this.OKCFILGLIDO * 2.8f, 1.4f, -this.OKCFILGLIDO, this.FFCKKEIGGAH, 2.8f);
            this.PAOAHFHFGKB = Physics.SphereCastNonAlloc(this.CMENBABHHPE - this.LCHFJIBGAPI * 2.8f, 1.4f, this.LCHFJIBGAPI, this.JOILAFJBPDI, 2.8f);
            this.DJGGIKOKKPF = Physics.SphereCastNonAlloc(this.CMENBABHHPE + this.LCHFJIBGAPI * 2.8f, 1.4f, -this.LCHFJIBGAPI, this.FINHEIOCNEA, 2.8f);
            this.CEGDBPCLCDE = Physics.SphereCastNonAlloc(this.FNGNILGGNEG.MultiplyPoint3x4(this.PAMPMLOLDGM), 0.2f, -this.HCEIKHOPMDK, this.AGKKCAKONLJ, 1.4f);
            this.INMKBENEKBD = Physics.SphereCastNonAlloc(this.FNGNILGGNEG.MultiplyPoint3x4(this.JOBKCJMOJIF), 0.2f, -this.HCEIKHOPMDK, this.BGMAGKCKNMG, 1.4f);
            this.MJILAGEIOOG.Clear();
            if (HFBFDKCOIIP)
            {
                this.DONMHGOAEGC(this.HKKECNGDFGK, this.LCCEIHGAGFA);
                this.DONMHGOAEGC(this.MPMGKOBOIEL, this.HGINJNBCOGL);
                this.DONMHGOAEGC(this.GJJOGGNEILP, this.BMAGNDKGPJH);
                this.DONMHGOAEGC(this.FFCKKEIGGAH, this.OKFFHPMALOP);
                this.DONMHGOAEGC(this.JOILAFJBPDI, this.PAOAHFHFGKB);
                this.DONMHGOAEGC(this.FINHEIOCNEA, this.DJGGIKOKKPF);
                this.DONMHGOAEGC(this.AGKKCAKONLJ, this.CEGDBPCLCDE);
                this.DONMHGOAEGC(this.BGMAGKCKNMG, this.INMKBENEKBD);
                return;
            }
            this.PDGAACODOIM(this.HKKECNGDFGK, this.LCCEIHGAGFA);
            this.PDGAACODOIM(this.MPMGKOBOIEL, this.HGINJNBCOGL);
            this.PDGAACODOIM(this.GJJOGGNEILP, this.BMAGNDKGPJH);
            this.PDGAACODOIM(this.FFCKKEIGGAH, this.OKFFHPMALOP);
            this.PDGAACODOIM(this.JOILAFJBPDI, this.PAOAHFHFGKB);
            this.PDGAACODOIM(this.FINHEIOCNEA, this.DJGGIKOKKPF);
            this.PDGAACODOIM(this.AGKKCAKONLJ, this.CEGDBPCLCDE);
            this.PDGAACODOIM(this.BGMAGKCKNMG, this.INMKBENEKBD);
        }


        private void Awake()
        {
            this.NHFOBDMPPBC = EffectIdManager.PunchAndGrabPosID;
        }


        private void NMGAENPIFMB(bool EBLNLDELEPD)
        {
            this.APNNJKDDNMG.Clear();
            this.MLIPKFPLDLJ.Clear();
            foreach (Vector3 item in this.MJILAGEIOOG)
            {
                float item2;
                //if (this.DIFHAJBFOKM(ref item, out item2, EBLNLDELEPD))
                //{
                this.APNNJKDDNMG.Add(item);
                //this.MLIPKFPLDLJ.Add(item2);
                //}
            }
        }


        private void AGAHLKICAFH(HashSet<Collider> PJFHMFKHHEI)
        {
            this.KMMHNLLOFEJ.Clear();
            this.AOCEHKOAIPE.Clear();
            Vector3 position = this.ELDPMCGDHKJ.localToWorldMatrix.MultiplyPoint3x4(this.JOBKCJMOJIF);
            foreach (Collider collider in PJFHMFKHHEI)
            {
                Vector3 point = collider.ClosestPoint(position);
                Vector3 item = this.OKBILNNGDJK.MultiplyPoint3x4(point);
                float item2;
                if (this.DIFHAJBFOKM(ref item, out item2, false))
                {
                    this.KMMHNLLOFEJ.Add(item);
                    this.AOCEHKOAIPE.Add(item2);
                }
            }
        }


        private void HAGNDOLLHGD()
        {
            this.LCCEIHGAGFA = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[0]), this.HKKECNGDFGK, 2f);
            this.HGINJNBCOGL = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[1]), this.MPMGKOBOIEL, 2f);
            this.BMAGNDKGPJH = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[2]), this.GJJOGGNEILP, 2f);
            this.OKFFHPMALOP = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[3]), this.FFCKKEIGGAH, 2f);
            this.PAOAHFHFGKB = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[4]), this.JOILAFJBPDI, 2f);
            this.DJGGIKOKKPF = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[5]), this.FINHEIOCNEA, 2f);
            this.CEGDBPCLCDE = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[6]), this.AGKKCAKONLJ, 2f);
            this.INMKBENEKBD = Physics.SphereCastNonAlloc(this.CMENBABHHPE, 0.3f, this.FNGNILGGNEG.MultiplyVector(GrabDetector.PFFBIILILNK.rayCastDirsForChinning[7]), this.BGMAGKCKNMG, 2f);
            this.MJILAGEIOOG.Clear();
            this.DONMHGOAEGC(this.HKKECNGDFGK, this.LCCEIHGAGFA);
            this.DONMHGOAEGC(this.MPMGKOBOIEL, this.HGINJNBCOGL);
            this.DONMHGOAEGC(this.GJJOGGNEILP, this.BMAGNDKGPJH);
            this.DONMHGOAEGC(this.FFCKKEIGGAH, this.OKFFHPMALOP);
            this.DONMHGOAEGC(this.JOILAFJBPDI, this.PAOAHFHFGKB);
            this.DONMHGOAEGC(this.FINHEIOCNEA, this.DJGGIKOKKPF);
            this.DONMHGOAEGC(this.AGKKCAKONLJ, this.CEGDBPCLCDE);
            this.DONMHGOAEGC(this.BGMAGKCKNMG, this.INMKBENEKBD);
        }

        internal PhysicCharacterController KPLKMDDKCML;

        internal Transform EIJAPLDDFEM;

        internal HashSet<GameObject> ADICJILOOEJ;

        internal Transform ELDPMCGDHKJ;

        internal Transform GHKDFNOINDC;

        private readonly Vector3 PAMPMLOLDGM = new Vector3(-0.284f, 0f, 0f);

        private readonly Vector3 JOBKCJMOJIF = new Vector3(0.284f, 0f, 0f);

        internal bool AMGIBPCJAMN;

        internal bool IKLPPDPJFJC;

        internal Vector3 LCAFMAOFKAM;

        internal Vector3 NOIJNEBKNOO;

        internal Weapon LKIEHLMCJCM;

        private Vector3 CMENBABHHPE;

        private Vector3 AMMKFHEIOMJ;

        private Vector3 LCHFJIBGAPI;

        private Vector3 OKCFILGLIDO;

        private Matrix4x4 FNGNILGGNEG;

        private Matrix4x4 OKBILNNGDJK;

        private Vector3 GKFDGDBHABK;

        private Vector3 HCEIKHOPMDK;

        private Matrix4x4 HLLBGJMNLLE;

        private Matrix4x4 JIHCDBGNLED;

        private Matrix4x4 NDGFOKBLIEN;

        private readonly Collider[] EFBPOKEMIFH = new Collider[30];

        private readonly HashSet<Collider> BPABADEEJEA = new HashSet<Collider>();

        private readonly Vector3 BOJOPFDPGLD = new Vector3(0f, -0.55f, -0.06f);

        private readonly Vector3 AFNBAACGAIL = new Vector3(0f, -0.321f, -0.06f);


        private readonly List<Vector3> KMFEGINMMEI = new List<Vector3>();

        private readonly List<float> IDDEJJNOODP = new List<float>();

        private readonly List<Vector3> KMMHNLLOFEJ = new List<Vector3>();

        private readonly List<float> AOCEHKOAIPE = new List<float>();


        private List<Vector3> MDJEKCGMJCJ = new List<Vector3>();

        private List<float> OMBAPHAINDA = new List<float>();

        private List<Vector3> APNNJKDDNMG = new List<Vector3>();

        private List<float> MLIPKFPLDLJ = new List<float>();

        private readonly HashSet<Weapon> OLAKOHNAKOA = new HashSet<Weapon>();


        private int NHFOBDMPPBC;

        private readonly HashSet<Collider> PJKHGEKNJHI = new HashSet<Collider>();

        [SerializeField]
        private List<Weapon> availableWeapons = new List<Weapon>();

        private readonly List<float> NNMMDJDMJDB = new List<float>();

        private RaycastHit AAOHBCGPIEG;


        private RaycastHit[] HKKECNGDFGK = new RaycastHit[30];

        private RaycastHit[] MPMGKOBOIEL = new RaycastHit[30];

        private RaycastHit[] GJJOGGNEILP = new RaycastHit[30];

        private RaycastHit[] FFCKKEIGGAH = new RaycastHit[30];

        private RaycastHit[] JOILAFJBPDI = new RaycastHit[30];

        private RaycastHit[] FINHEIOCNEA = new RaycastHit[30];

        private RaycastHit[] AGKKCAKONLJ = new RaycastHit[30];

        private RaycastHit[] BGMAGKCKNMG = new RaycastHit[30];

        private int LCCEIHGAGFA;

        private int HGINJNBCOGL;

        private int BMAGNDKGPJH;

        private int OKFFHPMALOP;

        private int PAOAHFHFGKB;

        private int DJGGIKOKKPF;

        private int CEGDBPCLCDE;

        private int INMKBENEKBD;

        private readonly List<Vector3> MJILAGEIOOG = new List<Vector3>();

        private Vector3 LCLEGNOCOGI;

        private static class PFFBIILILNK
        {
            static PFFBIILILNK()
            {
                float num = 3.1415927f;
                float num2 = Mathf.Sqrt(3f);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[0] = new Vector2((0.5f - 0.25f / num2) * num, 1.25f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[1] = new Vector2(0.5f * num, 1.5f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[2] = new Vector2((0.5f - 0.25f / num2) * num, 1.75f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[3] = new Vector2((0.5f - num2 * 0.15f) * num, 1.375f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[4] = new Vector2((0.5f - num2 * 0.15f) * num, 1.625f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[5] = new Vector2((0.5f - num2 / 24f) * num, 1.375f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[6] = new Vector2((0.5f - num2 / 24f) * num, 1.625f * num);
                GrabDetector.PFFBIILILNK.IOFJFMHHKFG[7] = new Vector2((0.5f - 0.25f / num2) * num, 1.5f * num);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[0] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[0]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[1] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[1]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[2] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[2]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[3] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[3]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[4] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[4]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[5] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[5]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[6] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[6]);
                GrabDetector.PFFBIILILNK.rayCastDirsForChinning[7] = GrabDetector.PFFBIILILNK.KOMFEKEJGON(GrabDetector.PFFBIILILNK.IOFJFMHHKFG[7]);
            }

            private static Vector3 KOMFEKEJGON(Vector2 FMMIHAJIAMG)
            {
                Vector3 result;
                result.x = Mathf.Sin(FMMIHAJIAMG.x) * Mathf.Cos(FMMIHAJIAMG.y);
                result.y = Mathf.Sin(FMMIHAJIAMG.x) * Mathf.Sin(FMMIHAJIAMG.y);
                result.z = Mathf.Cos(FMMIHAJIAMG.x);
                return result;
            }

            private static readonly Vector2[] IOFJFMHHKFG = new Vector2[8];

            public static readonly Vector3[] rayCastDirsForChinning = new Vector3[8];
        }
    }
}